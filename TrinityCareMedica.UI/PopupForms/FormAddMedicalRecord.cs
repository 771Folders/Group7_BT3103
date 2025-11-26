using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.AssignmentForms
{
    public partial class FormAddMedicalRecord : Form
    {
        MedicalRecordController medicalRecordController;
        public FormAddMedicalRecord()
        {
            InitializeComponent();
            medicalRecordController = new MedicalRecordController();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiagnosis.Text))
            {
                MessageBox.Show("Please enter the diagnosis.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GlobalVariables.medicalRecord = new MedicalRecordModel()
            {
                RecordID = medicalRecordController.GetNextMedicalRecordID(),
                PatientID = GlobalVariables.selectedPatientID,
                RecordDate = DateTime.Today,
                Diagnosis = txtDiagnosis.Text,
                Notes = txtNotes.Text
            };
            medicalRecordController.AddMedicalRecord(GlobalVariables.medicalRecord);
            if (!string.IsNullOrEmpty(GlobalVariables.medication.MedicationName))
                medicalRecordController.AddMedication(GlobalVariables.medication);
            if (!string.IsNullOrEmpty(GlobalVariables.treatment.TreatmentType))
                medicalRecordController.AddTreatment(GlobalVariables.treatment);
            DialogResult = DialogResult.OK;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnAddMedication_Click(object sender, EventArgs e)
        {
            FormAddMedication form = new FormAddMedication();
            form.ShowDialog();
        }
        private void btnAddTreatment_Click(object sender, EventArgs e)
        {
            FormAddTreatment form = new FormAddTreatment();
            form.ShowDialog();
        }
    }
}