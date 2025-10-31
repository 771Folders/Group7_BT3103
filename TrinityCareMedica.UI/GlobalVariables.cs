using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI
{
    public class GlobalVariables
    {
        public static string admissionAction = "Add";
        public static int selectedPatientID = 0;
        public static List<StaffModel> assignedStaff = new List<StaffModel>();
    }
}
