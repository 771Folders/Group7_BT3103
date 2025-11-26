using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.AssignmentForms
{
    public partial class FormAddTreatment : Form
    {
        MedicalRecordController medicalRecordController;
        public FormAddTreatment()
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
            if (string.IsNullOrEmpty(txtTreatment.Text))
            {
                MessageBox.Show("Please enter the treatment type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GlobalVariables.treatment = new TreatmentModel()
            {
                RecordID = medicalRecordController.GetNextMedicalRecordID(),
                TreatmentType = txtTreatment.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
