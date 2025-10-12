using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class RoomRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
        public List<RoomModel> GetAllRooms()
        {
            List<RoomModel> rooms = new List<RoomModel>();
            using (SqlConnection con  = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllRooms", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RoomModel room = new RoomModel
                            {
                                RoomID = reader.GetInt32(0),
                                RoomType = reader.GetString(1),
                                RoomNumber = reader.GetInt32(2),
                                Capacity = reader.GetInt32(3),
                                DailyRate = reader.GetDecimal(4)
                            };
                            rooms.Add(room);
                        }
                        return rooms;
                    }
                }
            }
        }
        public PatientRoomModel GetRoomByPatientID(int PatientID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomByPatientID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID",PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            PatientRoomModel room = new PatientRoomModel
                            {
                                RoomType = reader.GetString(0),
                                RoomNumber = reader.GetInt32(1),
                                BedNumber = reader.GetString(2),
                                StartDate = reader.GetDateTime(3),
                                EndDate = reader.GetDateTime(4)
                            };
                            return room;
                        }
                        return null;
                    }
                }
            }
        }
    }
}
