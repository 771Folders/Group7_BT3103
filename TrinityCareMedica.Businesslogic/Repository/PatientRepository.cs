using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class PatientRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
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
                    command.Parameters.AddWithValue("@Age", patient.Age);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@Phone", patient.Phone);
                    command.Parameters.AddWithValue("@Email", patient.Email);
                    command.Parameters.AddWithValue("@EmergencyContact", patient.EmergencyContact);
                    command.Parameters.AddWithValue("@EmergencyContactPhone", patient.EmergencyContactPhone);
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
                    command.Parameters.AddWithValue("@Age", patient.Age);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@Phone", patient.Phone);
                    command.Parameters.AddWithValue("@Email", patient.Email);
                    command.Parameters.AddWithValue("@EmergencyContact", patient.EmergencyContact);
                    command.Parameters.AddWithValue("@EmergencyContactPhone", patient.EmergencyContactPhone);
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
                    using (SqlCommand command = new SqlCommand("DeletePatient", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@PatientID", patientID);
                        command.ExecuteNonQuery();
                    }
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
                    using (SqlCommand command = new SqlCommand("GetPatientByID", con))
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
                                    Age = (int)reader["Age"],
                                    Gender = (string)reader["Gender"],
                                    Address = (string)reader["Address"],
                                    Phone = (string)reader["Phone"],
                                    Email = (string)reader["Email"],
                                    EmergencyContact = (string)reader["EmergencyContact"],
                                    EmergencyContactPhone = (string)reader["EmergencyContactPhone"],
                                    Status = (string)reader["Status"]
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
        public List<PatientModel> GetAllPatients()
        {
            try
            {
                List<PatientModel> patients = new List<PatientModel>();
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("GetAllPatients", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PatientModel patient = new PatientModel();
                                patient.PatientID = (int)reader["PatientID"];
                                patient.LastName = (string)reader["LastName"];
                                patient.FirstName = (string)reader["FirstName"];
                                patient.MiddleName = (string)reader["MiddleName"];
                                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                                patient.Age = (int)reader["Age"];
                                patient.Gender = (string)reader["Gender"];
                                patient.Address = (string)reader["Address"];
                                patient.Phone = (string)reader["Phone"];
                                patient.Email = (string)reader["Email"];
                                patient.EmergencyContact = (string)reader["EmergencyContact"];
                                patient.EmergencyContactPhone = (string)reader["EmergencyContactPhone"];
                                patient.Status = (string)reader["Status"];
                                patients.Add(patient);
                            }
                            return patients;
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
        public int GetNextPatientID()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("GetNextPatientID", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return Convert.ToInt32(reader["NextPatientID"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return -1;
        }
        public List<PatientModel> SearchPatient(string searchTerm)
        {
            try
            {
                List<PatientModel> patients = new List<PatientModel>();
                using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("SearchPatient", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SearchTerm", searchTerm);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PatientModel patient = new PatientModel();
                                patient.PatientID = (int)reader["PatientID"];
                                patient.LastName = (string)reader["LastName"];
                                patient.FirstName = (string)reader["FirstName"];
                                patient.MiddleName = (string)reader["MiddleName"];
                                patient.DateOfBirth = (DateTime)reader["DateOfBirth"];
                                patient.Age = (int)reader["Age"];
                                patient.Gender = (string)reader["Gender"];
                                patient.Address = (string)reader["Address"];
                                patient.Phone = (string)reader["Phone"];
                                patient.Email = (string)reader["Email"];
                                patient.EmergencyContact = (string)reader["EmergencyContact"];
                                patient.EmergencyContactPhone = (string)reader["EmergencyContactPhone"];
                                patient.Status = (string)reader["Status"];
                                patients.Add(patient);
                            }
                            return patients;
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
        public List<int> GetPatientAdmissionIDs(int PatientID)
        {
            List<int> admissions = new List<int>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetPatientAdmissionIDs", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            admissions.Add((int)reader["AdmissionID"]);
                    }
                }
            }
            return admissions;
        }
        public List<AdmissionHistoryModel> GetAllAdmissionCards()
        {
            try
            {
                List<AdmissionHistoryModel> admissionCards = new List<AdmissionHistoryModel>();
                using (SqlConnection conn = new SqlConnection(CONNECTIONSTRING))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.GetAllAdmissionCards", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AdmissionHistoryModel admissionCard = new AdmissionHistoryModel
                                {
                                    AdmissionID = (int)reader["AdmissionID"],
                                    PatientID = (int)reader["PatientID"],
                                    PatientName = (string)reader["PatientName"],
                                    Diagnosis = (string)reader["Diagnosis"],
                                    AdmissionDate = (DateTime)reader["AdmissionDate"],
                                    DischargeDate = reader["DischargeDate"] as DateTime?
                                };
                                admissionCards.Add(admissionCard);
                            }
                            return admissionCards;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
        public void DischargePatient(int PatientID, int AdmissionID)
        {
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("DischargePatient", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);
                    cmd.Parameters.AddWithValue("@AdmissionID", AdmissionID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}