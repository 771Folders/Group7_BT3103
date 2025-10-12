using System.Data;
using System.Data.SqlClient;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class StaffRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
        public List<StaffModel> GetAllStaff()
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<StaffModel> staffMembers = new List<StaffModel>();
                        while (reader.Read())
                        {
                            StaffModel staff = new StaffModel
                            {
                                StaffID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Department = reader.GetString(3),
                                Role = reader.GetString(4),
                                PhoneNumber = reader.GetString(5),
                                Email = reader.GetString(6),
                                DateHired = reader.GetDateTime(7)
                            };
                            staffMembers.Add(staff);
                        }
                        return staffMembers;
                    }
                }
            }
        }
        public List<DoctorModel> GetAllDoctors()
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllDoctors", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<DoctorModel> doctors = new List<DoctorModel>();
                        while (reader.Read())
                        {
                            DoctorModel doctor = new DoctorModel
                            {
                                DoctorID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Department = reader.GetString(3),
                                PhoneNumber = reader.GetString(4),
                                Email = reader.GetString(5),
                                DateHired = reader.GetDateTime(6)
                            };
                            doctors.Add(doctor);
                        }
                        return doctors;
                    }
                }
            }
        }
        public List<NurseModel> GetAllNurses()
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllNurses", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<NurseModel> nurses = new List<NurseModel>();
                        while (reader.Read())
                        {
                            NurseModel nurse = new NurseModel
                            {
                                NurseID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Department = reader.GetString(3),
                                PhoneNumber = reader.GetString(4),
                                Email = reader.GetString(5),
                                DateHired = reader.GetDateTime(6)
                            };
                            nurses.Add(nurse);
                        }
                        return nurses;
                    }
                }
            }
        }
        public List<AssignedStaffModel> GetAssignedStaff(int PatientID)
        {
            List<AssignedStaffModel> staff = new List<AssignedStaffModel>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAssignedStaff",con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staff.Add(new AssignedStaffModel
                            {
                                FirstName = reader.GetString(0),
                                LastName = reader.GetString(1),
                                Role = reader.GetString(2)
                            });
                        }
                        return staff;
                    }
                }
            }
        }
    }
}