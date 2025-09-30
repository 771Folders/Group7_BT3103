namespace EventDriven.Project.UI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    break;
                case "Doctor":
                    button2.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                    break;
                case "Nurse":
                    button2.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                    break;
                case "Cashier":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    break;
                case "Receptionist":
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInformationMaintenance formPatientInformationMaintenance = new FormPatientInformationMaintenance();
            formPatientInformationMaintenance.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmission formAdmission = new FormAdmission();
            formAdmission.ShowDialog();
        }
    }
}
