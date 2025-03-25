using Documentos.DataSets;
using Microsoft.Reporting.NETCore;

namespace Documentos.Generadores
{
    public class GenDoctoCFDI40
    {
        //CFDI
        private string _SPathRDLCCfdi;
        private CsCFDI40 _csCFDI40;

        //Datasets



        public GenDoctoCFDI40(string SPathRDLCCfdi, CsCFDI40 csCFDI40)
        {
            this._SPathRDLCCfdi = SPathRDLCCfdi;
            this._csCFDI40 = csCFDI40;
        }

        public byte[] GenPDFCFDI40()
        {
            try
            {
                Console.WriteLine("Generando documento cfdi");
                // ruta de alrchivo del rdlc de cfdi
                StreamReader _rdlcCfdi40 = new StreamReader(_SPathRDLCCfdi);
                LocalReport report = new LocalReport();
                report.EnableExternalImages = true;
                report.LoadReportDefinition(_rdlcCfdi40);

                //Carga de datasets a reporte
                report.DataSources.Add(new ReportDataSource("DsFacEnc", _csCFDI40._DsFacEnc));
                report.DataSources.Add(new ReportDataSource("DsDocto", _csCFDI40._DsDocto));
                report.DataSources.Add(new ReportDataSource("DsFacEncCli", _csCFDI40._DsFacEncCli));
                report.DataSources.Add(new ReportDataSource("DsFacCliSuc", _csCFDI40._DsFacCliSuc));
                report.DataSources.Add(new ReportDataSource("DsFacDet", _csCFDI40._DsFacDet));
                report.DataSources.Add(new ReportDataSource("DsCondPago", _csCFDI40._DsCondPago));
                report.DataSources.Add(new ReportDataSource("DsFacImportes", _csCFDI40._DsFacImportes));
                report.DataSources.Add(new ReportDataSource("DsDatosTimbrado", _csCFDI40._DsDatosTimbrado));

                
                // exporta el archivo a una ruta espesifica
                byte[] pdfCFDI = report.Render("PDF");

                return pdfCFDI;
            }
            catch (Exception a)
            {
                Console.WriteLine(a);
                throw;
            }
        }
    }
}
