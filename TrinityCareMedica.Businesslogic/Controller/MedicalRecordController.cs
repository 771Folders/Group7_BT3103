using TrinityCareMedica.Businesslogic.Repository;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Controller
{
    public class MedicalRecordController
    {
        private MedicalRecordRepository medicalRecordRepository;
        public MedicalRecordController()
        {
            medicalRecordRepository = new MedicalRecordRepository();
        }
        public List<MedicalRecordCardModel> GetMedicalRecordCards(int PatientID)
        {
            return medicalRecordRepository.GetMedicalRecordCards(PatientID);
        }
    }
}
