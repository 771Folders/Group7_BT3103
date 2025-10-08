using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=KOUTAIBA;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public UserModel ValidateUser(string Username, string Password)
        {
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection Hospital = new SqlConnection(CONNECTIONSTRING))
                {
                    Hospital.Open();
                    using (SqlCommand command = new SqlCommand("ValidateUser", Hospital))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Password", Password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                matchingUser = new UserModel
                                {
                                    Username = Username,
                                    Password = Password,
                                    Role = (string)reader["Role"]
                                };
                                return matchingUser;
                            }
                        }
                    }
                }
            }

            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            return null;
        }
    }
}