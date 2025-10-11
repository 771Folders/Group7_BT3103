using System.Configuration;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ConnectionString
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString;
        }
    }
}