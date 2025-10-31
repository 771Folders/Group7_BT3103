using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class StaffRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();

        public List<StaffModel> GetAllStaff()
        {
            List<StaffModel> staff = new List<StaffModel>();
            using (SqlConnection con  = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            staff.Add(new StaffModel()
                            {
                                StaffID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Department = reader.GetString(3),
                                Role = reader.GetString(4)
                            });
                        }
                    }
                }
            }
            return staff;
        }
        public void AssignStaff(int PatientID, int StaffID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("AssignStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.Parameters.AddWithValue("@StaffID", StaffID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public StaffModel GetStaffByID(int StaffID)
        {
            StaffModel staff = new StaffModel();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetStaffByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StaffID", StaffID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            staff = new StaffModel
                            {
                                StaffID = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                Department = reader.GetString(3),
                                Role = reader.GetString(4)
                            };
                        }
                    }
                }
            }
            return staff;
        }
        public List<int> GetAssignedStaff(int PatientID)
        {
            List<int> assignedStaff = new List<int>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAssignedStaff", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assignedStaff.Add(reader.GetInt32(0));
                        }
                    }
                }
            }
            return assignedStaff;
        }
        public void DeleteStaffAssignments(int PatientID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteStaffAssignments", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
