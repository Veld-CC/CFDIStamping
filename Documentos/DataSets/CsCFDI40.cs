namespace Documentos.DataSets
{
    public class CsCFDI40
    {

        public List<DsFacEnc> _DsFacEnc { get; set; }
        public List<DsDocto> _DsDocto { get; set; }
        public List<DsFacEncCli> _DsFacEncCli { get; set; }
        public List<DsFacCliSuc> _DsFacCliSuc { get; set; }
        public List<DsFacDet> _DsFacDet { get; set; }
        public List<DsCondPago> _DsCondPago { get; set; }
        public List<DsFacImportes> _DsFacImportes { get; set; }
        public List<DsDatosTimbrado> _DsDatosTimbrado { get; set; }



        public class DsFacEnc
        {
            public string PathLogo { get; set; }
            public string RazonSocial { get; set; }
            public string Direccion { get; set; }
            public string LugarExpedicion { get; set; }
            public string Telefono { get; set; }
            public string RegimenFiscal { get; set; }
            public string RFC { get; set; }
            public string CodigoPostal { get; set; }
        }

        public class DsDocto
        {
            public string TipoDocto { get; set; }
            public string SerieFolioFac { get; set; }
            public DateTime Fecha { get; set; }
        }

        public class DsFacEncCli
        {
            public string IDCliente { get; set; }
            public string RazonSocial { get; set; }
            public string RegimenFiscal { get; set; }
            public string Direccion { get; set; }
            public string RFC { get; set; }
            public string CodigoPostal { get; set; }
        }

        public class DsFacCliSuc
        {
            public string SucCli { get; set; }
            public string Direccion { get; set; }
            public string CodigoPostal { get; set; }
            public string Ruta { get; set; }
            public string Zona { get; set; }
        }

        public class DsFacDet
        {
            public string Cantidad { get; set; }
            public string Clave { get; set; }
            public string Descripcion { get; set; }
            public string Marca { get; set; }
            public string Unidad { get; set; }
            public string CodigoInterno { get; set; }
            public string PorcentajeDescuento { get; set; }
            public string PrecioUnitario { get; set; }
            public string Importe { get; set; }
            public string IVA { get; set; }
        }

        public class DsCondPago
        {
            public string ImporteLetra { get; set; }
            public string MetodoDePago { get; set; }
            public string FormaDePago { get; set; }
            public string UsoCFDI { get; set; }
            public string Moneda { get; set; }
            public string TipoComprobante { get; set; }
        }

        public class DsFacImportes
        {
            public string Importe { get; set; }
            public string DescuentoPorVolumen { get; set; }
            public string DescuentoMayoreo { get; set; }
            public string DescuentoProntoPago { get; set; }
            public string DescuentoOferta { get; set; }
            public string DescuentoEspecial { get; set; }
            public string Subtotal { get; set; }
            public string IVA { get; set; }
            public string ImporteIVA { get; set; }
            public string RetencionIVA { get; set; }
            public string ImporteRetencionIVA { get; set; }
            public string Total { get; set; }
        }

        public class DsDatosTimbrado
        {
            public string CadenaOriginal { get; set; }
            public string SelloDigital { get; set; }
            public string SelloSAT { get; set; }
            public string UUID { get; set; }
            public string FechaTimbrado { get; set; }
            public string NoCertidicadoSAT { get; set; }
            public string NoCertificadoEmisor { get; set; }
            public string PathQR { get; set; }
        }
    }



}
