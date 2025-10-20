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
                                EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? (DateTime?)null : reader.GetDateTime(4)
                            };
                            return room;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
        public void AssignRoom(int PatientID, PatientRoomModel room)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("AssignRoom", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.Parameters.AddWithValue("@RoomNumber", room.RoomNumber);
                    cmd.Parameters.AddWithValue("@BedNumber", room.BedNumber);
                    cmd.Parameters.AddWithValue("@StartDate", room.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", room.EndDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<PatientRoomModel> GetRoomAssignmentModels()
        {
            List<PatientRoomModel> rooms = new List<PatientRoomModel>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomAssignmentModels", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rooms.Add(new PatientRoomModel()
                            {
                                RoomType = reader.GetString(0),
                                RoomNumber = reader.GetInt32(1)
                            });
                        }
                        return rooms;
                    }
                }
            }
        }
        public void DeleteRoomAssignment(int PatientID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteRoomAssignment", con))
                {
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<int> GetRoomNumbers(string RoomType)
        {
            List<int> roomNumbers = new List<int>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomNumbers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomNumbers.Add(reader.GetInt32(0));
                        }
                        return roomNumbers;
                    }
                }
            }
        }
        public int GetRoomCapacity(string RoomType)
        {
            int roomCapacity = 0;
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomCapacity", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return roomCapacity = reader.GetInt32(0);
                        }
                        return 0;
                    }
                }
            }
        }
        public List<string> GetRoomTypes()
        {
            List<string> roomTypes = new List<string>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetRoomTypes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            roomTypes.Add(reader.GetString(0));
                        }
                        return roomTypes;
                    }
                } 
            }
        }
        public List<string> GetAvailableBedNumbers(string RoomType, int RoomNumber)
        {
            List<string> availableBedNumbers = new List<string>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAvailableBedNumbers", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomType", RoomType);
                    cmd.Parameters.AddWithValue("@RoomNumber", RoomNumber);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableBedNumbers.Add(reader.GetString(0));
                        }
                        return availableBedNumbers;
                    }
                }
            }
        }
    }
}