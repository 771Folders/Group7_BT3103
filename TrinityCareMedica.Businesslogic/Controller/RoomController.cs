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
        public void AssignRoom(int PatientID, PatientRoomModel room)
        {
            roomRepository.AssignRoom(PatientID, room);
        }
        public List<PatientRoomModel> GetRoomAssignmentModels()
        {
            return roomRepository.GetRoomAssignmentModels();
        }
        public void DeleteRoomAssignment(int PatientID)
        {
            roomRepository.DeleteRoomAssignment(PatientID);
        }
        public List<int> GetRoomNumbers(string RoomType)
        {
            return roomRepository.GetRoomNumbers(RoomType);
        }
        public int GetRoomCapacity(string RoomType)
        {
            return roomRepository.GetRoomCapacity(RoomType);
        }
        public List<string> GetRoomTypes()
        {
            return roomRepository.GetRoomTypes();
        }
        public List<string> GetAvailableBedNumbers(string RoomType, int RoomNumber)
        {
            return roomRepository.GetAvailableBedNumbers(RoomType, RoomNumber);
        }
    }
}
