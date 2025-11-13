namespace TrinityCareMedica.Model
{
    public class AssignedRoomModel
    {
        public int RoomID { get; set; }
        public int PatientID { get; set; }
        public int AdmissionID { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public int BedNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
