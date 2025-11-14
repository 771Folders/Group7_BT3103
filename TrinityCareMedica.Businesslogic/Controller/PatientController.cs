using TrinityCareMedica.Businesslogic.Repository;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Controller
{
    public class PatientController
    {
        private PatientRepository patientRepo;
        public PatientController()
        {
            patientRepo = new PatientRepository();
        }
        public List<PatientModel> GetAllPatients()
        {
            return patientRepo.GetAllPatients();
        }
        public PatientModel GetPatientByID(int patientId)
        {
            return patientRepo.GetPatientByID(patientId);
        }
        public void AddPatient(PatientModel patient)
        {
            patientRepo.AddPatient(patient);
        } 
        public void EditPatient(PatientModel patient)
        {
            patientRepo.EditPatient(patient);
        }
        public void DeletePatient(int patientId)
        {
            patientRepo.DeletePatient(patientId);
        }
        public List<PatientModel> SearchPatients(string searchTerm)
        {
            return patientRepo.SearchPatient(searchTerm);
        }
        public int GetNextPatientID()
        {
            return patientRepo.GetNextPatientID();
        }
        public List<int> GetPatientAdmissionIDs(int PatientID)
        {
            return patientRepo.GetPatientAdmissionIDs(PatientID);
        }
        public List<AdmissionHistoryModel> GetAllAdmissionCards()
        {
            return patientRepo.GetAllAdmissionCards();
        }
        public void DischargePatient(int PatientID, int AdmissionID)
        {
            patientRepo.DischargePatient(PatientID, AdmissionID);
        }
    }
}
