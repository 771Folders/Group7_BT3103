namespace TrinityCareMedica.Model
{
    public class AdmissionHistoryModel
    {
        public int AdmissionID { get; set; }
        public int PatientID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
    }
}
