using TrinityCareMedica.Model;
using System.Data;
using System.Data.SqlClient;

namespace TrinityCareMedica.Businesslogic.Repository
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = ConnectionString.GetConnectionString();
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