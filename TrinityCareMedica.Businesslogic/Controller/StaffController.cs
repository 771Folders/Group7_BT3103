using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityCareMedica.Businesslogic.Repository;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Controller
{
    public class StaffController
    {
        private StaffRepository staffRepository;
        public StaffController()
        {
            staffRepository = new StaffRepository();
        }
        public List<StaffModel> GetAllStaff()
        {
            return staffRepository.GetAllStaff();
        }
        public void AssignStaff(int PatientID, int StaffID)
        {
            staffRepository.AssignStaff(PatientID, StaffID);
        }
        public StaffModel GetStaffByID(int StaffID)
        {
            return staffRepository.GetStaffByID(StaffID);
        }
        public List<int> GetAssignedStaff(int PatientID)
        {
            return staffRepository.GetAssignedStaff(PatientID);
        }
        public void DeleteStaffAssignments(int PatientID)
        {
            staffRepository.DeleteStaffAssignments(PatientID);
        }
    }
}
