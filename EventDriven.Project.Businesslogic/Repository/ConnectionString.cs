using System.Configuration;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ConnectionString
    {
        public static string GetConnectionString()
        {
            switch (Environment.MachineName)
            {
                case "KOUTAIBA":
                    return ConfigurationManager.ConnectionStrings["771Folders"].ConnectionString;
                default:
                    return null;
            }
        }
    }
}