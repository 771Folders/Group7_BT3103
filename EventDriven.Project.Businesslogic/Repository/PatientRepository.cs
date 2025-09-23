using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class PatientRepository
    {
        private string CONNECTIONSTRING = "Data Source=KOUTAIBA;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public void AddPatient(PatientModel patient)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("AddPatient", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@MiddleName", patient.MiddleName);
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@Phone", patient.Phone);
                    command.Parameters.AddWithValue("@Email", patient.Email);
                    command.Parameters.AddWithValue("@EmergencyContact", patient.EmergencyContact);
                    command.Parameters.AddWithValue("@DateRegistered", patient.DateRegistered);
                    command.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void EditPatient(PatientModel patient)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("EditPatient", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientID", patient.PatientID);
                    command.Parameters.AddWithValue("@LastName", patient.LastName);
                    command.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    command.Parameters.AddWithValue("@MiddleName", patient.MiddleName);
                    command.Parameters.AddWithValue("@DateOfBirth", patient.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@Phone", patient.Phone);
                    command.Parameters.AddWithValue("@Email", patient.Email);
                    command.Parameters.AddWithValue("@EmergencyContact", patient.EmergencyContact);
                    command.Parameters.AddWithValue("@DateRegistered", patient.DateRegistered);
                    command.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void DeletePatient(int patientID)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("DeletePatient", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientID", patientID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public PatientModel GetPatientByID(int patientID)
        {
            try
            {
                PatientModel patient;
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.GetPatientByID", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", patientID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                patient = new PatientModel
                                {
                                    PatientID = (int)reader["PatientID"],
                                    LastName = (string)reader["LastName"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = (string)reader["Gender"],
                                    Address = (string)reader["Address"],
                                    Phone = (long)reader["Phone"],
                                    Email = (string)reader["Email"],
                                    EmergencyContact = (string)reader["EmergencyContact"],
                                    DateRegistered = (DateTime)reader["DateRegistered"]
                                };
                                return patient;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }

        public List<PatientModel> GetPatientByFirstName(string FirstName)
        {
            try
            {
                List<PatientModel> patient = new List<PatientModel>();
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.GetPatientByFirstName", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patient.Add(new PatientModel()
                                {
                                    PatientID = (int)reader["PatientID"],
                                    LastName = (string)reader["LastName"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = (string)reader["Gender"],
                                    Address = (string)reader["Address"],
                                    Phone = (long)reader["Phone"],
                                    Email = (string)reader["Email"],
                                    EmergencyContact = (string)reader["EmergencyContact"],
                                    DateRegistered = (DateTime)reader["DateRegistered"]
                                });
                                return patient;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }

        public List<PatientModel> GetPatientByLastName(string LastName)
        {
            try
            {
                List<PatientModel> patient = new List<PatientModel>();
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.GetPatientByLastName", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LastName", LastName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patient.Add(new PatientModel()
                                {
                                    PatientID = (int)reader["PatientID"],
                                    LastName = (string)reader["LastName"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = (string)reader["Gender"],
                                    Address = (string)reader["Address"],
                                    Phone = (long)reader["Phone"],
                                    Email = (string)reader["Email"],
                                    EmergencyContact = (string)reader["EmergencyContact"],
                                    DateRegistered = (DateTime)reader["DateRegistered"]
                                });
                                return patient;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }

        public List<PatientModel> GetPatientByMiddleName(string MiddleName)
        {
            try
            {
                List<PatientModel> patient = new List<PatientModel>();
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.GetPatientByMiddleName", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MiddleName", MiddleName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patient.Add(new PatientModel()
                                {
                                    PatientID = (int)reader["PatientID"],
                                    LastName = (string)reader["LastName"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = (string)reader["Gender"],
                                    Address = (string)reader["Address"],
                                    Phone = (long)reader["Phone"],
                                    Email = (string)reader["Email"],
                                    EmergencyContact = (string)reader["EmergencyContact"],
                                    DateRegistered = (DateTime)reader["DateRegistered"]
                                });
                                return patient;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }

        public List<PatientModel> GetAllPatients()
        {
            try
            {
                List<PatientModel> patients = new List<PatientModel>();
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("dbo.GetAllPatients", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                patients.Add(new PatientModel()
                                {
                                    PatientID = (int)reader["PatientID"],
                                    LastName = (string)reader["LastName"],
                                    FirstName = (string)reader["FirstName"],
                                    MiddleName = (string)reader["MiddleName"],
                                    DateOfBirth = (DateTime)reader["DateOfBirth"],
                                    Gender = (string)reader["Gender"],
                                    Address = (string)reader["Address"],
                                    Phone = (long)reader["Phone"],
                                    Email = (string)reader["Email"],
                                    EmergencyContact = (string)reader["EmergencyContact"],
                                    DateRegistered = (DateTime)reader["DateRegistered"]
                                });
                                return patients;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
