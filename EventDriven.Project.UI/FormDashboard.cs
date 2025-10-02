using EventDriven.Project.Businesslogic.Controller;

namespace EventDriven.Project.UI
{
    public partial class FormDashboard : Form
    {
        PatientController patientController;
        public FormDashboard()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            lblPatientCount.Text = patientController.GetAllPatients().Count.ToString() + "\nAdmitted";
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormPatientInformationMaintenance formPatientInformationMaintenance = new FormPatientInformationMaintenance();
            formPatientInformationMaintenance.ShowDialog();
            Hide();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            panel3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel6.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BorderStyle = BorderStyle.None;
        }
    }
}
