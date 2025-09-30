using EventDriven.Project.Model;
using EventDriven.Project.Businesslogic.Repository;
using System.Diagnostics;

namespace EventDriven.Project.Businesslogic.Controller
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
            try
            {
                if (patientRepo.GetPatientByFirstName(searchTerm) != null)
                {
                    return patientRepo.GetPatientByFirstName(searchTerm);
                }
                else if (patientRepo.GetPatientByLastName(searchTerm) != null)
                {
                    return patientRepo.GetPatientByLastName(searchTerm);
                }
                else if (patientRepo.GetPatientByMiddleName(searchTerm) != null)
                {
                    return patientRepo.GetPatientByMiddleName(searchTerm);
                }
                else if (patientRepo.GetPatientByID(Convert.ToInt32(searchTerm)) != null)
                {
                    return new List<PatientModel> { patientRepo.GetPatientByID(Convert.ToInt32(searchTerm)) };
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

        public int GetNextPatientID()
        {
            return patientRepo.GetNextPatientID();
        }
    }
}
