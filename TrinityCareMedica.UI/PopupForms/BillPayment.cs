using System.Security.Cryptography;
using System.Windows.Forms;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class BillPayment : Form
    {
        BillingController billingController;
        BillingModel billing;
        PatientController patientController;
        int selectedPatientID;
        int admissionID;
        public event EventHandler GoToBillingSummary;
        public BillPayment(int AdmissionID)
        {
            InitializeComponent();
            billingController = new BillingController();
            patientController = new PatientController();
            admissionID = AdmissionID;
            selectedPatientID = GlobalVariables.selectedPatientID;
            billing = billingController.GenerateBilling(admissionID);
            txtBalance.Text = billing.Balance.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            int billingID = billing.BillingID;
            decimal payment = Convert.ToDecimal(txtPayment.Text);
            GlobalVariables.billingSummary = billingController.ConfirmPayment(billingID, payment);
            MessageBox.Show("Payment Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToBillingSummary?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }
}
