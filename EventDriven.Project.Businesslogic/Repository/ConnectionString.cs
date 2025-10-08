using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class ConnectionString
    {
        public static string GetConnectionString()
        {
            return "Data Source=KOUTAIBA;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }
    }
}
