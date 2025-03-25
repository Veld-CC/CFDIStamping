
using Timbrado.Models;

namespace Dyn.CFDI.CFDIS
{
    public class CanCFDI40
    {
        public async void CancelarCFDI40(ParametrosCan can)
        {
            try
            {
                // Aquí iría la lógica real de cancelacion timbrado, depende del proveedor de timbrado

                string sXml = "";
                //Guardar el response del acuse de cancelacion
                System.IO.File.WriteAllText(can.SSPathAcuseCancelacion, sXml);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}