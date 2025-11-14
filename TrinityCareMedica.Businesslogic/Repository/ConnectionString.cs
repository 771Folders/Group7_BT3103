using System.Configuration;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class ConnectionString
    {
        public static string GetConnectionString()
        {
            switch (Environment.MachineName)
            {
                case "KOUTAIBA":
                    return ConfigurationManager.ConnectionStrings["771Folders"].ConnectionString;
                case "JACE":
                    return ConfigurationManager.ConnectionStrings["JACE"].ConnectionString;
                case "DESKTOP-PAF1DCT":
                    return ConfigurationManager.ConnectionStrings["Dodi"].ConnectionString;
                default:
                    return null;
            }
        }
    }
}