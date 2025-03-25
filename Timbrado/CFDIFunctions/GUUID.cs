namespace Timbrado.CFDIFunctions
{
    public class GUUID
    {
        public static string GetIDCCP()
        {
            // Generar un Guid
            Guid idCCP = Guid.NewGuid();

            // Convertir el Guid a una cadena en formato canónico
            string idCCPString = idCCP.ToString();

            //reemplazar los 3 primeros caracteres por CCC espesificados por el SAT
            idCCPString = "CCC" + idCCPString.Substring(3);

            return idCCPString.ToUpper();
        }
    }
}
