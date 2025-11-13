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
            GlobalVariables.medicalRecord = new MedicalRecordModel()
            {
                RecordID = medicalRecordController.GetNextMedicalRecordID(),
                PatientID = GlobalVariables.selectedPatientID,
                RecordDate = DateTime.Today,
                Diagnosis = txtDiagnosis.Text,
                Notes = txtNotes.Text
            };
            medicalRecordController.AddMedicalRecord(GlobalVariables.medicalRecord);
            if (GlobalVariables.medication.MedicationID > 0)
                medicalRecordController.AddMedication(GlobalVariables.medication);
            if (GlobalVariables.treatment.TreatmentID > 0)
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