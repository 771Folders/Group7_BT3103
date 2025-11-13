using System.Data;
using System.Data.SqlClient;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class RoomRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
        public List<RoomModel> GetAllRooms()
        {
            List<RoomModel> rooms = new List<RoomModel>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
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
                                RoomId = reader.GetInt32(0),
                                RoomType = reader.GetString(1),
                                RoomNumber = reader.GetInt32(2),
                                RatePerDay = reader.GetDecimal(3),
                                Capacity = reader.GetInt32(4)
                            };
                            rooms.Add(room);
                        }
                    }
                }
            }
            return rooms;
        }
        public RoomModel GetRoomByRoomID(int RoomID)
        {
            RoomModel room = new RoomModel();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomByRoomID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            room = new RoomModel
                            {
                                RoomId = reader.GetInt32(0),
                                RoomType = reader.GetString(1),
                                RoomNumber = reader.GetInt32(2),
                                RatePerDay = reader.GetDecimal(3),
                                Capacity = reader.GetInt32(4)
                            };
                        }
                    }
                }
            }
            return room;
        }
        public AssignedRoomModel GetCurrentRoom(int PatientID)
        {
            AssignedRoomModel assignedRoom = new AssignedRoomModel();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetCurrentRoom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            assignedRoom = new AssignedRoomModel
                            {
                                RoomID = (int)reader["RoomID"],
                                AdmissionID = (int)reader["AdmissionID"],
                                RoomType = (string)reader["RoomType"],
                                RoomNumber = (int)reader["RoomNumber"],
                                BedNumber = (int)reader["BedNumber"],
                                StartDate = (DateTime)reader["StartDate"],
                                EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? (DateTime?)null : (DateTime)reader["EndDate"]
                            };
                        }
                    }
                }
            }
            return assignedRoom;
        }
        public void AssignRoom(AssignedRoomModel room)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("AssignRoom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", room.PatientID);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@BedNumber", room.BedNumber);
                    cmd.Parameters.AddWithValue("@StartDate", room.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", (object?)room.EndDate ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}