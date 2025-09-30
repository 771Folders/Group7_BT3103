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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoggedUser = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
