using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.AssignmentForms
{
    public partial class FormSelectPatient : Form
    {
        PatientController patientController;
        List<PatientModel> patients;
        public FormSelectPatient()
        {
            InitializeComponent();
            patientController = new PatientController();
            patients = patientController.GetAllPatients();
            txtPatientName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();
            foreach (PatientModel patient in patients)
            {
                list.Add($"{patient.FirstName} {patient.MiddleName} {patient.LastName}");
            }
            txtPatientName.AutoCompleteCustomSource = list;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                MessageBox.Show("Please enter the patient name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (patientController.SearchPatients(txtPatientName.Text).Count <= 0)
            {
                MessageBox.Show("Patient not found", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<PatientModel> searchResult = patientController.SearchPatients(txtPatientName.Text);
            GlobalVariables.selectedPatientID = searchResult[0].PatientID;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}