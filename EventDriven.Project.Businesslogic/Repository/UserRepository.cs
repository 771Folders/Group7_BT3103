using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=KOUTAIBA;Initial Catalog=Hospital;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

         public UserModel ValidateUser(string Username, string Password)//Form1 Validate User
        {
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection Hospital = new SqlConnection(CONNECTIONSTRING))
                {
                    Hospital.Open();
                    using (SqlCommand command = new SqlCommand("dbo.ValidateUser", Hospital))
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
        public UserModel getUserByUserId(string UserIdParam)
        {
            try { 
            UserModel matchingUser = new UserModel();
            using (SqlConnection myConnection = new SqlConnection(CONNECTIONSTRING))
            {
                string oString = "SELECT * FROM User WHERE Id = @userId";
                using (SqlCommand oCmd = new SqlCommand(oString, myConnection))
                {
                    oCmd.Parameters.AddWithValue("@UserId", UserIdParam);
                    myConnection.Open();
                    using (SqlDataReader oReader = oCmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {

                            matchingUser.Id = (int)oReader["Id"];
                            matchingUser.Username = oReader["Username"].ToString();
                            matchingUser.Password = oReader["Password"].ToString();
                        }
                        myConnection.Close();

                    }
                }
                
            }
            
                if (matchingUser.Id == 0)
                {
                    throw new Exception("User does not exist");
                }

                return matchingUser;
            }
            
            catch (Exception ex)
            {
                
                throw new Exception("An error occurred: " + ex.Message);
            }
        }

       
    }
}
        
    