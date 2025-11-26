using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.AssignmentForms
{
    public partial class FormAddMedication : Form
    {
        MedicalRecordController medicalRecordController;
        public FormAddMedication()
        {
            InitializeComponent();
            medicalRecordController = new MedicalRecordController();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMedicationName.Text))
            {
                MessageBox.Show("Please enter the medication name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GlobalVariables.medication = new MedicationModel()
            {
                RecordID = medicalRecordController.GetNextMedicalRecordID(),
                MedicationName = txtMedicationName.Text,
                FrequencyCount = Convert.ToInt32(txtCount.Text),
                FrequencyInterval = Convert.ToInt32(txtInterval.Text),
                Duration = Convert.ToInt32(txtDuration.Text),
                Price = Convert.ToDecimal(txtPrice.Text)
            };
            Close();
        }
    }
}