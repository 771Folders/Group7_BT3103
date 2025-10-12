using TrinityCareMedica.Businesslogic.Repository;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Controller
{
    public class RoomController
    {
        private RoomRepository roomRepository;
        public RoomController()
        {
            roomRepository = new RoomRepository();
        }
        public List<RoomModel> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }
        public PatientRoomModel GetRoomByPatientID(int PatientID)
        {
            return roomRepository.GetRoomByPatientID(PatientID);
        }
    }
}
