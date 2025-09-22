using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {

        public static UserModel LoggedUser;
        private UserController userController;

        public FormLogin()
        {
            InitializeComponent();
            userController = new UserController();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel matchingUser = userController.ValidateUser(txtUsername.Text, txtPassword.Text);
                if (matchingUser != null)
                {
                    LoggedUser = matchingUser;
                    Hide();
                    FormDashboard formDashboard = new FormDashboard();
                    formDashboard.ShowDialog();
                }
                else throw new Exception("Invalid Credentials");
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
