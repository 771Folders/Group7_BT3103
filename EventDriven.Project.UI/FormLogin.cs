using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormLogin : Form
    {
        #region Global Variables
        public static UserModel LoggedUser;
        #endregion
        #region Local Variables
        private UserController userController;
        #endregion
        public FormLogin()
        {
            InitializeComponent();
            DoubleBuffering();
            userController = new UserController();
        }

        private void DoubleBuffering()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                panel1,
                new object[] { true });
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                flowLayoutPanel1, // <- replace with your actual name
                new object[] { true });
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                flowLayoutPanel2, // <- second one
                new object[] { true });
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
                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();
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
