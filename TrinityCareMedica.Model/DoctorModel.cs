namespace TrinityCareMedica.Model
{
    public class DoctorModel
    {
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateHired { get; set; }
    }
}
