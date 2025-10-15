using System.Data;
using System.Data.SqlClient;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class MedicalRecordRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
        public List<MedicalRecordCardModel> GetMedicalRecordCards(int PatientID)
        {
            try
            {
                List<MedicalRecordCardModel> medicalRecords = new List<MedicalRecordCardModel>();
                using (SqlConnection con  = new SqlConnection(CONNECTIONSTRING))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("GetMedicalRecord", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PatientID", PatientID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MedicalRecordCardModel record = new MedicalRecordCardModel
                                {
                                    RecordID = Convert.ToInt32(reader["RecordID"]),
                                    RecordDate = Convert.ToDateTime(reader["RecordDate"]),
                                    RoomName = reader["RoomName"].ToString(),
                                    Diagnosis = reader["Diagnosis"].ToString(),
                                    Notes = reader["Notes"].ToString(),
                                    Medications = reader["Medications"].ToString(),
                                    Treatments = reader["Treatments"].ToString()
                                };
                                medicalRecords.Add(record);
                            }
                            return medicalRecords;
                        }
                    } 
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
