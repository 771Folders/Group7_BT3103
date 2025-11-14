namespace TrinityCareMedica.Model
{
    public class AdmissionHistoryModel
    {
        public int AdmissionID { get; set; }
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string Diagnosis {  get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
    }
}
