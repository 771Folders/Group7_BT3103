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
            if (txtPayment.Text == string.Empty)
            {
                MessageBox.Show("Please enter payment amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDecimal(txtPayment.Text) < (Convert.ToDecimal(txtBalance.Text) * Convert.ToDecimal(0.3)))
            {
                MessageBox.Show($"Payment must be at least 30% of the balance or {Convert.ToDecimal(txtBalance.Text) * Convert.ToDecimal(0.3)}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int billingID = billing.BillingID;
            decimal payment = Convert.ToDecimal(txtPayment.Text);
            GlobalVariables.billingSummary = billingController.ConfirmPayment(billingID, payment);
            MessageBox.Show("Payment Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToBillingSummary?.Invoke(this, EventArgs.Empty);
            Close();
        }
        private void formatting(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == string.Empty)
            {
                return;
            }
            textBox.Text = string.Format("{0:C2}", Convert.ToDecimal(textBox.Text));
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPayment.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
