namespace EventDriven.Project.Model
{
    public class PatientModel
    {
        public int PatientID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string EmergencyContact { get; set; }
        public string DateRegistered { get; set; }
    }
}
