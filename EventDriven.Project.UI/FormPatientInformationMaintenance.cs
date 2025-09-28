using EventDriven.Project.Businesslogic.Controller;

namespace EventDriven.Project.UI
{
    public partial class FormPatientInformationMaintenance : Form
    {
        PatientController patientController;
        public FormPatientInformationMaintenance()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmission formAdmission = new FormAdmission();
            formAdmission.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void FormPatientInformationMaintenance_Load(object sender, EventArgs e)
        {
            CheckLoggedUser();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = patientController.GetAllPatients();
        }

        private void CheckLoggedUser()
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    addBtn.Visible = true;
                    break;
                case "Doctor":
                    button2.Visible = false;
                    button4.Visible = false;
                    addBtn.Visible = false;
                    break;
                case "Nurse":
                    button2.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                    addBtn.Visible = false;
                    break;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmission formAdmission = new FormAdmission();
            formAdmission.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (patientController.SearchPatients(txtSearch.Text) != null)
            {
                dataGridView1.DataSource = patientController.SearchPatients(txtSearch.Text);
            }
            else
            {
                MessageBox.Show("No matching records found.");
                LoadData();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int selected = Convert.ToInt32(row.Cells["PatientID"].Value);
                DialogResult res = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    patientController.DeletePatient(selected);
                    LoadData();
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Canceled");
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
