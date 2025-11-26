using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class MedicalRecordCard : UserControl
    {
        public event EventHandler LoadMedicalRecords;
        MedicalRecordController medicalRecordController;
        MedicalRecordModel medicalRecord;
        TreatmentModel treatment;
        MedicationModel medication;
        public MedicalRecordCard(int RecordID)
        {
            InitializeComponent();
            medicalRecordController = new MedicalRecordController();
            medicalRecord = medicalRecordController.GetMedicalRecordByID(RecordID);
            treatment = medicalRecordController.GetTreatmentByRecordID(RecordID);
            medication = medicalRecordController.GetMedicationByRecordID(RecordID);
            LoadData();
        }
        private void LoadData()
        {
            txtDiagnosis.Text = medicalRecord.Diagnosis;
            txtNotes.Text = medicalRecord.Notes;
            lblRecordDate.Text = medicalRecord.RecordDate.ToShortDateString();
            if (!string.IsNullOrEmpty(treatment.TreatmentType))
                txtTreatment.Text = treatment.TreatmentType;
            if (!string.IsNullOrEmpty(medication.MedicationName))
                txtMedication.Text = $"{medication.MedicationName} {Environment.NewLine}{medication.FrequencyCount} Every {medication.FrequencyInterval} Hours For {medication.Duration} Days";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                medicalRecordController.DeleteMedicalRecordByID(medicalRecord.RecordID);
            }
            else
            {
                MessageBox.Show("Deletion Cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadMedicalRecords?.Invoke(this, EventArgs.Empty);
        }
        private void removeFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
