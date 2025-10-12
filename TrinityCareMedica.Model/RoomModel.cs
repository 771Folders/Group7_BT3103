namespace TrinityCareMedica.Model
{
    public class RoomModel
    {
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public decimal DailyRate { get; set; }
    }
}
