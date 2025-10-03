using System;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;

namespace EventDriven.Project.UI.UserControls
{
    public partial class PatientInformationMaintenance : UserControl
    {
        PatientController patientController;
        public event EventHandler GoToDashboard;
        public event EventHandler GoToAddPatient;
        public event EventHandler GoToEditPatient;
        public PatientInformationMaintenance()
        {
            InitializeComponent();
            patientController = new PatientController();
            CheckLoggedUser();
        }

        private void CheckLoggedUser()
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    break;
                case "Doctor":
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    break;
                case "Nurse":
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    break;
                case "Receptionist":
                    break;
                case "Cashier":
                    MessageBox.Show("You do not have permission to access this module.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GoToDashboard?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }

        private void PatientInformationMaintenance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataPatients.DataSource = patientController.GetAllPatients();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();
                dataPatients.DataSource = patientController.SearchPatients(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoToAddPatient?.Invoke(this, EventArgs.Empty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataPatients.CurrentRow != null)
            {
                DataGridViewRow row = dataPatients.CurrentRow;
                int selected = Convert.ToInt32(row.Cells["PatientID"].Value);
                FormMain.selectedPatientID = selected;
            }
            GoToEditPatient?.Invoke(this, EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataPatients.SelectedRows.Count > 0)
                {
                    int patientId = Convert.ToInt32(dataPatients.SelectedRows[0].Cells["PatientID"].Value);
                    DialogResult confirmResult = MessageBox.Show("Are you sure to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        patientController.DeletePatient(patientId);
                        txtSearch.Clear();
                        LoadData();
                        MessageBox.Show("Patient deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Deletion cancelled.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a patient to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deletion: " + ex.Message);
            }
        }
    }
}