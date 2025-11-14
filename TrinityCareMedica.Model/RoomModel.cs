namespace TrinityCareMedica.Model
{
    public class RoomModel
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public int RoomNumber { get; set; }
        public decimal RatePerDay { get; set; }
        public int Capacity { get; set; }
    }
}
