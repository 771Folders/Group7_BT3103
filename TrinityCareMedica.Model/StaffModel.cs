using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityCareMedica.Model
{
    public class StaffModel
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department {  get; set; }
        public string Role { get; set; }
    }
}
