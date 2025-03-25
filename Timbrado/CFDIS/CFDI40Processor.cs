using System.Drawing;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Credencials.Core;
using Newtonsoft.Json;
using QRCoder;
using Timbrado.CFDIS.CFDI._40;
using Timbrado.CFDIS.TFD._11;
using Timbrado.CFDIS.Utils;
using Timbrado.Models;
using Formatting = Newtonsoft.Json.Formatting;

namespace Timbrado.CFDIS
{
    public class CFDI40Processor
    {
        private Comprobante _comprobante;
        private Parametros _parametros;
        private TimbreFiscalDigital _timbreFiscal;
        private string _cadenaOriginal;

        public async Task<ResponseTimbrado> TimbrarCFDI40(Comprobante comprobante, object complemento, Parametros parametros)
        {
            try
            {
                InitializeComponents(comprobante, parametros);
                
                if (complemento != null)
                {
                    ProcessComplement(complemento);
                }

                GenerateCertificateNumber();
                var xmlWithSignature = SignCFDI();
                var xmlContent = CreateXmlFile(xmlWithSignature);
                
                _timbreFiscal = await TimbrarXml();

                return CreateResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void InitializeComponents(Comprobante comprobante, Parametros parametros)
        {
            _comprobante = comprobante;
            _parametros = parametros;
            _timbreFiscal = new TimbreFiscalDigital();
        }

        private void ProcessComplement(object complemento)
        {
            var complementProcessor = new ComplementProcessor(_comprobante, _parametros);
            _comprobante.Complemento = complementProcessor.Process(complemento);
        }

        private void GenerateCertificateNumber()
        {
            _comprobante.NoCertificado = new CertificateService().GetCertificateNumber(_parametros.FIleCer);
        }

        private Comprobante SignCFDI()
        {
            var signer = new CFDISigner(_parametros);
            _cadenaOriginal = signer.GenerateCadenaOriginal(_parametros.pathXML);
            return signer.ApplySignature(_comprobante, _cadenaOriginal);
        }

        private string CreateXmlFile(Comprobante comprobante)
        {
            var xmlGenerator = new XmlGenerator(_parametros);
            return xmlGenerator.GenerateXml(comprobante, _parametros.SComplemento, _parametros.SVersion);
        }

        private async Task<TimbreFiscalDigital> TimbrarXml()
        {
            var timbradoService = new TimbradoService(_parametros, _comprobante);
            return await timbradoService.ProcesarTimbrado();
        }

        private ResponseTimbrado CreateResponse()
        {
            return new ResponseTimbrado
            {
                timbreFiscalDigital = _timbreFiscal
            };
        }
    }

    public class ComplementProcessor
    {
        private readonly Comprobante _comprobante;
        private readonly Parametros _parametros;

        public ComplementProcessor(Comprobante comprobante, Parametros parametros)
        {
            _comprobante = comprobante;
            _parametros = parametros;
        }

        public ComprobanteComplemento Process(object complemento)
        {
            return _parametros.SComplemento switch
            {
                "CartaPorte" => ProcessCartaPorte(complemento),
                "Detallista" => ProcessDetallista(complemento),
                _ => throw new NotSupportedException($"Complemento no soportado: {_parametros.SComplemento}")
            };
        }

        private ComprobanteComplemento ProcessCartaPorte(object complemento)
        {
            SetCartaPorteSchemaLocation();
            return new ComplementSerializer().Serialize(complemento, GetCartaPorteNamespaces());
        }

        private void SetCartaPorteSchemaLocation()
        {
            _comprobante.xsiSchemaLocation = _parametros.SVersion switch
            {
                "20" => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/CartaPorte20 http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte20.xsd",
                "30" => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/CartaPorte30 http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte30.xsd",
                "31" => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/CartaPorte31 http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte31.xsd",
                _ => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd"
            };
        }

        private XmlSerializerNamespaces GetCartaPorteNamespaces()
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            var prefix = _parametros.SVersion switch
            {
                "20" => "cartaporte20",
                "30" => "cartaporte30",
                _ => null
            };

            if (prefix != null)
            {
                namespaces.Add(prefix, $"http://www.sat.gob.mx/CartaPorte{_parametros.SVersion}");
            }

            return namespaces;
        }

        private ComprobanteComplemento ProcessDetallista(object complemento)
        {
            SetDetallistaSchemaLocation();
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("detallista", "http://www.sat.gob.mx/detallista");
            return new ComplementSerializer().Serialize(complemento, namespaces);
        }

        private void SetDetallistaSchemaLocation()
        {
            _comprobante.xsiSchemaLocation = "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/detallista http://www.sat.gob.mx/sitio_internet/cfd/detallista/detallista.xsd";
        }
    }

    public class ComplementSerializer
    {
        public ComprobanteComplemento Serialize(object complemento, XmlSerializerNamespaces namespaces)
        {
            var serializer = new XmlSerializer(complemento.GetType());
            var xmlDoc = new XmlDocument();
            
            using (var sw = new StringWriterWithEncoding(Encoding.UTF8))
            {
                using (var writer = XmlWriter.Create(sw))
                {
                    serializer.Serialize(writer, complemento, namespaces);
                    xmlDoc.LoadXml(sw.ToString());
                }
            }

            return new ComprobanteComplemento
            {
                Any = new[] { xmlDoc.DocumentElement }
            };
        }
    }

    public class CertificateService
    {
        public string GetCertificateNumber(byte[] cerBytes)
        {
            var cerBase64 = Convert.ToBase64String(cerBytes);
            var certificate = new Certificate(cerBase64);
            return certificate.CertificateNumber;
        }
    }

    public class XmlGenerator
    {
        private readonly Parametros _parametros;

        public XmlGenerator(Parametros parametros)
        {
            _parametros = parametros;
        }

        public string GenerateXml(Comprobante comprobante, string complemento, string version)
        {
            var namespaces = CreateNamespaces(complemento, version);
            SetSchemaLocation(comprobante, complemento, version);

            var serializer = new XmlSerializer(typeof(Comprobante));
            string xmlContent;

            using (var sw = new StringWriterWithEncoding(Encoding.UTF8))
            {
                using (var writer = XmlWriter.Create(sw))
                {
                    serializer.Serialize(writer, comprobante, namespaces);
                    xmlContent = sw.ToString();
                }
            }

            File.WriteAllText(_parametros.pathXML, xmlContent);
            return xmlContent;
        }

        private XmlSerializerNamespaces CreateNamespaces(string complemento, string version)
        {
            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add("cfdi", "http://www.sat.gob.mx/cfd/4");
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");

            if (complemento == "CartaPorte")
            {
                var prefix = version switch
                {
                    "20" => "cartaporte20",
                    "30" => "cartaporte30",
                    _ => null
                };

                if (prefix != null)
                {
                    namespaces.Add(prefix, $"http://www.sat.gob.mx/CartaPorte{version}");
                }
            }
            else if (complemento == "Detallista" && version == "81")
            {
                namespaces.Add("detallista", "http://www.sat.gob.mx/detallista");
            }

            return namespaces;
        }

        private void SetSchemaLocation(Comprobante comprobante, string complemento, string version)
        {
            if (string.IsNullOrEmpty(comprobante.xsiSchemaLocation))
            {
                comprobante.xsiSchemaLocation = complemento switch
                {
                    "CartaPorte" => version switch
                    {
                        "20" => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/CartaPorte20 http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte20.xsd",
                        "30" => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/CartaPorte30 http://www.sat.gob.mx/sitio_internet/cfd/CartaPorte/CartaPorte30.xsd",
                        _ => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd"
                    },
                    "Detallista" => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd http://www.sat.gob.mx/detallista http://www.sat.gob.mx/sitio_internet/cfd/detallista/detallista.xsd",
                    _ => "http://www.sat.gob.mx/cfd/4 http://www.sat.gob.mx/sitio_internet/cfd/4/cfdv40.xsd"
                };
            }
        }
    }

    public class CFDISigner
    {
        private readonly Parametros _parametros;

        public CFDISigner(Parametros parametros)
        {
            _parametros = parametros;
        }

        public string GenerateCadenaOriginal(string xmlPath)
        {
            var transformador = new XslCompiledTransform(true);
            var sets = new XsltSettings(true, true);
            var resolver = new XmlUrlResolver();
            transformador.Load(_parametros.pathCadenaOriginal, sets, resolver);

            using (var sw = new StringWriter())
            using (var xwo = XmlWriter.Create(sw, transformador.OutputSettings))
            {
                transformador.Transform(xmlPath, xwo);
                return sw.ToString();
            }
        }

        public Comprobante ApplySignature(Comprobante comprobante, string cadenaOriginal)
        {
            var selloDigital = new SelloDigital();
            comprobante.Certificado = selloDigital.Certificado(_parametros.FIleCer);
            comprobante.Sello = selloDigital.Sellar(cadenaOriginal, _parametros.FileKey, _parametros.ClavePrivada);
            return comprobante;
        }
    }

    public class TimbradoService
    {
        private readonly Parametros _parametros;
        private readonly Comprobante _comprobante;

        public TimbradoService(Parametros parametros, Comprobante comprobante)
        {
            _parametros = parametros;
            _comprobante = comprobante;
        }

        public async Task<TimbreFiscalDigital> ProcesarTimbrado()
        {
            try
            {
                // Aquí iría la lógica real de timbrado de tu proveedor
                var sXml = ""; // Obtendría el XML timbrado
                File.WriteAllText(_parametros.pathXMLTimbrado, sXml);

                var timbre = GetDataTFD(sXml);
                GenerateQRCode(timbre);
                SaveTimbreAsJson(timbre);

                return timbre;
            }
            catch (Exception ex)
            {
                throw new Exception("No se timbró el XML" + "\nCódigo de error: " + ex.Message);
            }
        }

        private TimbreFiscalDigital GetDataTFD(string xmlContent)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xmlContent);
            var elemList = doc.GetElementsByTagName("tfd:TimbreFiscalDigital");
            var xmlTFD = elemList[0].OuterXml;

            var serializer = new XmlSerializer(typeof(TimbreFiscalDigital));
            using (var reader = new StringReader(xmlTFD))
            {
                var timbre = (TimbreFiscalDigital)serializer.Deserialize(reader);
                timbre.CadenaCertificada = GenerateCertifiedChain(xmlTFD);
                return timbre;
            }
        }

        private string GenerateCertifiedChain(string xmlTFD)
        {
            var transformador = new XslCompiledTransform(true);
            var sets = new XsltSettings(true, true);
            var resolver = new XmlUrlResolver();
            transformador.Load(_parametros.pathCadenaOriginalTFD, sets, resolver);

            using (var sw = new StringWriter())
            using (var xwo = XmlWriter.Create(sw, transformador.OutputSettings))
            using (var xr = XmlReader.Create(new StringReader(xmlTFD)))
            {
                transformador.Transform(xr, xwo);
                return sw.ToString();
            }
        }

        private void GenerateQRCode(TimbreFiscalDigital timbre)
        {
            var cfdSubstring = timbre.SelloCFD.Substring(timbre.SelloCFD.Length - 8);
            var qrGenerator = new QRCodeGeneratorService();
            qrGenerator.GenerateCFDIQR(
                timbre.UUID,
                _comprobante.Emisor.Rfc,
                _comprobante.Receptor.Rfc,
                _comprobante.Total.ToString(),
                cfdSubstring,
                _parametros.pathBmpQR
            );
        }

        private void SaveTimbreAsJson(TimbreFiscalDigital timbre)
        {
            var json = JsonConvert.SerializeObject(timbre, (Formatting)Formatting.Indented);
            File.WriteAllText(_parametros.pathJsonTFD, json);
        }
    }

    public class QRCodeGeneratorService
    {
        public void GenerateCFDIQR(string uuid, string emisorRfc, string receptorRfc, string total, string sello, string outputPath)
        {
            try
            {
                var url = $"https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?&id={uuid}&re={emisorRfc}&rr={receptorRfc}&tt={total}&fe={sello}";
                GenerateQRCode(url, outputPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public void GenerateCCPQR(string idCCP, string fechaSalidaLlegada, string fechaTimbrado, string outputPath)
        {
            try
            {
                var url = $"https://verificacfdi.facturaelectronica.sat.gob.mx/verificaccp/default.aspx?&IdCCP={idCCP}&FechaOrig={fechaSalidaLlegada}&FechaTimb={fechaTimbrado}";
                var qrBytes = GenerateQRCode(url);
                CropAndSaveQR(qrBytes, outputPath, 330);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        
        
        private byte[] GenerateQRCode(string content)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(5);
        }

        private void GenerateQRCode(string content, string outputPath)
        {
            var qrBytes = GenerateQRCode(content);
            File.WriteAllBytes(outputPath, qrBytes);
        }

        private void CropAndSaveQR(byte[] qrBytes, string outputPath, int cropSize)
        {
            using (var stream = new MemoryStream(qrBytes))
            using (var originalImage = new Bitmap(stream))
            {
                var cropArea = new Rectangle(
                    (originalImage.Width - cropSize) / 2,
                    (originalImage.Height - cropSize) / 2,
                    cropSize,
                    cropSize
                );

                using (var croppedImage = originalImage.Clone(cropArea, originalImage.PixelFormat))
                {
                    croppedImage.Save(outputPath);
                }
            }
        }
    }
}