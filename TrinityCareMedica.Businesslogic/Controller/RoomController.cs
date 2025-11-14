using TrinityCareMedica.Businesslogic.Repository;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Controller
{
    public class RoomController
    {
        RoomRepository roomRepository;
        public RoomController()
        {
            roomRepository = new RoomRepository();
        }
        public List<RoomModel> GetAllRooms()
        {
            return roomRepository.GetAllRooms();
        }
        public RoomModel GetRoomByRoomID(int RoomID)
        {
            return roomRepository.GetRoomByRoomID(RoomID);
        }
        public AssignedRoomModel GetCurrentRoom(int PatientID)
        {
            return roomRepository.GetCurrentRoom(PatientID);
        }
        public void AssignRoom(AssignedRoomModel room)
        {
            roomRepository.AssignRoom(room);
        }
    }
}
