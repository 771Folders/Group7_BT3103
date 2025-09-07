using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {

        private UserController userController;

        public FormLogin()
        {
            InitializeComponent();
            userController = new UserController();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel matchingUser = userController.ValidateUser(txtUsername.Text, txtPassword.Text);
                if (matchingUser != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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
