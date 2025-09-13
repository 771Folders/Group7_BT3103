using EventDriven.Project.Model;
using EventDriven.Project.Businesslogic.Repository;

namespace EventDriven.Project.Businesslogic.Controller
{
    public class PatientController
    {
        private PatientRepository patientRepo;

        public PatientController()
        {
            patientRepo = new PatientRepository();
        }
    }
}
