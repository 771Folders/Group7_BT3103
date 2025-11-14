using System.Data;
using System.Data.SqlClient;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class BillingRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
        public BillingModel GenerateBilling(int AdmissionID)
        {
            BillingModel billing = new BillingModel();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GenerateBilling", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdmissionID", AdmissionID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            billing = new BillingModel()
                            {
                                BillingID = (int)reader["BillingID"],
                                AdmissionID = (int)reader["AdmissionID"],
                                PatientID = (int)reader["PatientID"],
                                TotalAmount = (decimal)reader["TotalAmount"],
                                AmountPaid = (decimal)reader["AmountPaid"],
                                Balance = (decimal)reader["Balance"],
                                BillingDate = (DateTime)reader["BillingDate"]
                            };
                        }
                    }
                }
            }
            return billing;
        }
        public List<BillingDetailsModel> GetBillingDetails(int AdmissionID)
        {
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetBillingDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AdmissionID", AdmissionID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            billingDetails.Add(new BillingDetailsModel()
                            {
                                AdmissionID = (int)reader["AdmissionID"],
                                Service = (string)reader["Service"],
                                Quantity = (int)reader["Quantity"],
                                Price = (decimal)reader["Price"],
                                Total = (decimal)reader["Total"]
                            });
                        }
                    }
                }
            }
            return billingDetails;
        }
        public BillingModel ConfirmPayment(int BillingID, decimal AmountPaid)
        {
            BillingModel billingModel = new BillingModel();
            using (SqlConnection con = new SqlConnection(CONNECTIONSTRING))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("ConfirmPayment", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BillingID", BillingID);
                    cmd.Parameters.AddWithValue("@AmountPaid", AmountPaid);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            billingModel = new BillingModel()
                            {
                                BillingID = (int)reader["BillingID"],
                                AdmissionID = (int)reader["AdmissionID"],
                                PatientID = (int)reader["PatientID"],
                                BillingDate = (DateTime)reader["BillingDate"],
                                TotalAmount = (decimal)reader["TotalAmount"],
                                AmountPaid = (decimal)reader["AmountPaid"],
                                Balance = (decimal)reader["Balance"]
                            };
                        }
                    }
                }
            }
            return billingModel;
        }
    }
}