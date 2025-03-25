namespace Timbrado.Models
{
    /// <summary>
    /// Clase que contiene todos los parámetros necesarios para el proceso de generación,
    /// sellado y timbrado de CFDI 4.0 con sus respectivos complementos.
    /// </summary>
    public class Parametros
    {
        /// <summary>
        /// Ruta completa del archivo de imagen del logo de la empresa que genera el documento.
        /// Ejemplo: C:\logos\miempresa.png
        /// </summary>
        public string LogoEmpresa { get; set; }

        /// <summary>
        /// Certificado digital (.cer) en formato byte array para sellar el comprobante.
        /// Debe estar en formato DER codificado en base64.
        /// </summary>
        public byte[] FIleCer { get; set; }

        /// <summary>
        /// Llave privada (.key) en formato byte array para sellar el comprobante.
        /// Debe estar en formato PEM codificado en base64.
        /// </summary>
        public byte[] FileKey { get; set; }

        /// <summary>
        /// Contraseña de la llave privada para poder utilizarla en el sellado digital.
        /// </summary>
        public string ClavePrivada { get; set; }

        /// <summary>
        /// Ruta completa del archivo XSLT para generar la cadena original del CFDI.
        /// Ejemplo: C:\xslt\cadenaoriginal_4_0.xslt
        /// </summary>
        public string pathCadenaOriginal { get; set; }

        /// <summary>
        /// Ruta completa del archivo XSLT para generar la cadena original del Timbre Fiscal Digital.
        /// Ejemplo: C:\xslt\cadenaoriginal_TFD_1_1.xslt
        /// </summary>
        public string pathCadenaOriginalTFD { get; set; }

        /// <summary>
        /// API Key proporcionada por el proveedor de timbrado para autenticar las solicitudes.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Ruta completa donde se generará el archivo XML del comprobante antes del timbrado.
        /// Ejemplo: C:\cfdi\AAA010101AAA_1234_st.xml
        /// </summary>
        public string pathXML { get; set; }

        /// <summary>
        /// Ruta completa donde se generará el archivo XML del comprobante después del timbrado.
        /// Ejemplo: C:\cfdi\AAA010101AAA_1234.xml
        /// </summary>
        public string pathXMLTimbrado { get; set; }

        /// <summary>
        /// Ruta completa donde se generará el archivo JSON con los datos del timbrado.
        /// Ejemplo: C:\cfdi\AAA010101AAA_1234.json
        /// </summary>
        public string pathJsonTFD { get; set; }

        /// <summary>
        /// Ruta completa donde se generará la imagen del código QR del CFDI en formato BMP.
        /// Ejemplo: C:\cfdi\AAA010101AAA_1234_qr.bmp
        /// </summary>
        public string pathBmpQR { get; set; }

        /// <summary>
        /// Ruta completa donde se generará la imagen del código QR del IDCCP (Identificador de Carta Porte) en formato BMP.
        /// Ejemplo: C:\cfdi\AAA010101AAA_1234_qr_idccp.bmp
        /// </summary>
        public string pathBmpQRIDccp { get; set; }

        /// <summary>
        /// Ruta completa donde se generará el archivo PDF del comprobante fiscal.
        /// Ejemplo: C:\cfdi\AAA010101AAA_1234.pdf
        /// </summary>
        public string pathCreatePDF { get; set; }

        /// <summary>
        /// Versión del CFDI que se está generando (ej. "4.0").
        /// </summary>
        public string SVersionCFDI { get; set; }

        /// <summary>
        /// Tipo de complemento que se incluirá en el CFDI (ej. "CartaPorte", "Detallista").
        /// </summary>
        public string SComplemento { get; set; }

        /// <summary>
        /// Versión del complemento que se incluirá en el CFDI (ej. "2.0", "3.0" para Carta Porte).
        /// </summary>
        public string SVersion { get; set; }
    }
}