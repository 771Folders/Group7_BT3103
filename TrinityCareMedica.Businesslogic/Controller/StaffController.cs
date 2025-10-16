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
        StaffRepository staffRepository;
        public StaffController()
        {
            staffRepository = new StaffRepository();
        }
        public List<StaffModel> GetAllStaff()
        {
            return staffRepository.GetAllStaff();
        }
        public List<DoctorModel> GetAllDoctors()
        {
            return staffRepository.GetAllDoctors();
        }
        public List<NurseModel> GetAllNurses()
        {
            return staffRepository.GetAllNurses();
        }
        public List<AssignedStaffModel> GetAssignedStaff(int PatientID)
        {
            return staffRepository.GetAssignedStaff(PatientID);
        }
        public int GetStaffIDByName(string Name)
        {
            return staffRepository.GetStaffIDByName(Name);
        }
        public void AssignStaff(int PatientID, int StaffID)
        {
            staffRepository.AssignStaff(PatientID, StaffID);
        }
        public void DeleteAllAssignedStaff(int PatientID)
        {
            staffRepository.DeleteAllAssignedStaff(PatientID);
        }
    }
}
