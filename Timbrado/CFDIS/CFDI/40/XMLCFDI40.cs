namespace Timbrado.CFDIS.CFDI._40
{
	public class XMLCFDI40
	{
		private Comprobante _comprobante = new Comprobante();
		//Para generar certificados
		private string pathCer = @"C:\XXXXX\PKI\CSD_Sucursal.cer";

		public Comprobante GeneraXmlCFDI40Ejemplo()
		{
			//_comprobante = Encabezado();
			//_comprobante.Emisor = Emisor();
			//_comprobante.Receptor = Receptor();
			//_comprobante.Conceptos = Conceptos();
			//_comprobante.Impuestos = Impuestos();

			//_comprobante.Complemento = ComplementoCartaPorte20();

			#region cfdi relacionados

   //         ComprobanteCfdiRelacionados rel = new ComprobanteCfdiRelacionados();
			//rel.TipoRelacion = "04";

			//List<ComprobanteCfdiRelacionadosCfdiRelacionado> rellist = new List<ComprobanteCfdiRelacionadosCfdiRelacionado>();

			//ComprobanteCfdiRelacionadosCfdiRelacionado uuid = new ComprobanteCfdiRelacionadosCfdiRelacionado();
			//uuid.UUID = "69825ec5-298e-487c-be39-453e303d0c87";
			//rellist.Add(uuid);

			//rel.CfdiRelacionado = rellist.ToArray();

   //         List<ComprobanteCfdiRelacionados> _crel = new List<ComprobanteCfdiRelacionados>();

			// _crel.Add(rel);
			//_comprobante.CfdiRelacionados = _crel.ToArray();

			#endregion




			return _comprobante;
		}

		

		//private Comprobante Encabezado()
		//{
		//	Comprobante _enc = new Comprobante();

		//	_enc.CondicionesDePago = "PAGO EN UNA SOLA EXHIBICION";


		//	_enc.Descuento = (decimal)20700.00;
		//	_enc.Exportacion = "01";
		//	_enc.Fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
		//	_enc.Folio = "1";
		//	_enc.FormaPago = "99";
		//	_enc.LugarExpedicion = "06370";
		//	_enc.MetodoPago = "PPD";

		//	_enc.Moneda = "MXN";

		//	//_enc.NoCertificado = GetCertificado().CertificateNumber;

		//	var cer = GetCertificado();

		//	//_enc.Sello = 
		//	_enc.Serie = "T";
		//	_enc.SubTotal = "82800.00";
		//	_enc.TipoCambio = (decimal)1;
		//	_enc.TipoDeComprobante = "I";
		//	_enc.Total = (decimal)72036.00;
		//	_enc.Version = "4.0";

		//	return _enc;
		//}

		//private ComprobanteEmisor Emisor()
		//{
		//	ComprobanteEmisor _emisor = new ComprobanteEmisor();

		//	_emisor.Rfc = "EKU9003173C9";
		//	_emisor.Nombre = "ESCUELA KEMPER URGATE";
		//	_emisor.RegimenFiscal = "601";
		

		//	return _emisor;
		//}

		//private ComprobanteReceptor Receptor()
		//{
		//	ComprobanteReceptor _receptor = new ComprobanteReceptor();
		//	_receptor.Nombre = "JUAN PEREZ DE LEON";
		//	_receptor.Rfc = "XAXX010101000";
		//	_receptor.UsoCFDI = "S01";
		//	_receptor.RegimenFiscalReceptor = "616";
		//	_receptor.DomicilioFiscalReceptor = "06370";
			

		//	return _receptor;

		//}

		//private ComprobanteConcepto[] Conceptos()
		//{
		//	List<ComprobanteConcepto> lstConceptos = new List<ComprobanteConcepto>();
		//	ComprobanteConcepto _concepto = new ComprobanteConcepto();

		//	_concepto.Cantidad = 360;
		//	_concepto.ClaveProdServ = "30111601";
		//	_concepto.ClaveUnidad = "XSA";
		//	_concepto.Descripcion = "CEMENTO GRIS ANAHUAC/MTY. EXTRA BULTO 50KG";
		//	_concepto.Importe = (decimal)82800.00;
		//	_concepto.Descuento = (decimal)20700.00;
		//	_concepto.NoIdentificacion = "014356"; // clave del friadsys
		//	_concepto.ObjetoImp = "02";
		//	_concepto.Unidad = "BULTO C/50 KG";
		//	_concepto.ValorUnitario = (decimal)230.0000;
		//	_concepto.Descuento = (decimal)20700.00;
		//	_concepto.DescuentoSpecified = true; // habilita el descuento

  //          ComprobanteConceptoImpuestos _impuesto = new ComprobanteConceptoImpuestos();


		//	List<ComprobanteConceptoImpuestosTraslado> _lsttraslado = new List<ComprobanteConceptoImpuestosTraslado>();
		//	ComprobanteConceptoImpuestosTraslado _traslado = new ComprobanteConceptoImpuestosTraslado();

		//	_traslado.Base = (decimal)62100.00;
		//	_traslado.Importe = (decimal)9936.00;
		//	_traslado.Impuesto = "002";
		//	_traslado.TasaOCuota = "0.160000";
		//	_traslado.TipoFactor = "Tasa";

		//	_lsttraslado.Add(_traslado);

		//	_impuesto.Traslados = _lsttraslado.ToArray();

		//	_concepto.Impuestos = _impuesto;

		//	lstConceptos.Add(_concepto);

		//	return lstConceptos.ToArray();
		//}

  //      private ComprobanteImpuestos Impuestos()
  //      {
  //          ComprobanteImpuestos _impuestos = new ComprobanteImpuestos();

  //          _impuestos.TotalImpuestosTrasladados = (decimal)9936.00;

  //          List<ComprobanteImpuestosTraslado> _ltsimpuestostraslado = new List<ComprobanteImpuestosTraslado>();

  //          ComprobanteImpuestosTraslado _traslado = new ComprobanteImpuestosTraslado();
  //          _traslado.Base = (decimal)62100.00;
  //          _traslado.Importe = (decimal)9936.00;
  //          _traslado.Impuesto = "002";
  //          _traslado.TasaOCuota = "0.160000";
  //          _traslado.TipoFactor = "Tasa";

  //          _ltsimpuestostraslado.Add(_traslado);

  //          _impuestos.Traslados = _ltsimpuestostraslado.ToArray();


  //          return _impuestos;
  //      }




  //      private Certificate GetCertificado()
		//{
		//	var cerBytes = File.ReadAllBytes(pathCer);
		//	var cerBase64 = Convert.ToBase64String(cerBytes);
		//	var certificate = new Certificate(cerBase64);

		//	return certificate;

		//}
	}

	
}
