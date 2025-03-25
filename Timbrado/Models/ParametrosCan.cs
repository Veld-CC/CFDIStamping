namespace Timbrado.Models
{
    /// <summary>
    /// Clase que contiene los parámetros necesarios para el proceso de cancelación
    /// de un CFDI (Comprobante Fiscal Digital por Internet) ante el SAT.
    /// </summary>
    public class ParametrosCan
    {
        /// <summary>
        /// API Key de autenticación para el servicio de cancelación (32 caracteres alfanuméricos).
        /// Ejemplo: "A1B2C3D4E5F6G7H8I9J0K1L2M3N4O5P6Q7R8"
        /// </summary>
        public string SApikey { get; set; }

        /// <summary>
        /// Contenido de la llave privada (.key) en formato PEM codificado en base64.
        /// Debe corresponder al CSD (Certificado de Sello Digital) del emisor.
        /// </summary>
        public string SKeyCSD { get; set; }

        /// <summary>
        /// Contenido del certificado digital (.cer) en formato DER codificado en base64.
        /// Debe corresponder al CSD (Certificado de Sello Digital) del emisor.
        /// </summary>
        public string SCerCSD { get; set; }

        /// <summary>
        /// Contraseña de la llave privada del CSD, proporcionada al SAT durante el registro.
        /// </summary>
        public string SPassCSD { get; set; }

        /// <summary>
        /// UUID (Identificador Único Universal) del CFDI que se desea cancelar.
        /// Formato: 00000000-0000-0000-0000-000000000000
        /// </summary>
        public string SUuid { get; set; }

        /// <summary>
        /// RFC del emisor del CFDI que se desea cancelar.
        /// Ejemplo: "AAA010101AAA"
        /// </summary>
        public string SRfcEmisor { get; set; }

        /// <summary>
        /// RFC del receptor del CFDI que se desea cancelar.
        /// Ejemplo: "XAXX010101000"
        /// </summary>
        public string SRfcReceptor { get; set; }

        /// <summary>
        /// Monto total exacto que aparece en el CFDI a cancelar.
        /// Debe coincidir exactamente con el valor en el documento original.
        /// </summary>
        public double DTotal { get; set; }

        /// <summary>
        /// Motivo de la cancelación según el catálogo del SAT:
        /// "01" - Comprobante emitido con errores con relación
        /// "02" - Comprobante emitido con errores sin relación
        /// "03" - No se llevó a cabo la operación
        /// "04" - Operación nominativa relacionada en la factura global
        /// </summary>
        public string SMotivo { get; set; }

        /// <summary>
        /// Folio fiscal (UUID) del CFDI que sustituye al documento cancelado.
        /// Solo aplica cuando el motivo de cancelación es "01".
        /// Formato: 00000000-0000-0000-0000-000000000000
        /// </summary>
        public string SFolioSustitucion { get; set; }

        /// <summary>
        /// Ruta completa donde se generará el archivo XML con el acuse de cancelación.
        /// Ejemplo: "C:\cancelaciones\AAA010101AAA_1234_can.xml"
        /// </summary>
        public string SSPathAcuseCancelacion { get; set; }
    }
}