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
                    return ConfigurationManager.ConnectionStrings["jace"].ConnectionString;
                default:
                    return null;
            }
        }
    }
}