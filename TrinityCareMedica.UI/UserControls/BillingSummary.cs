using System.Windows.Forms;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class BillingSummary : UserControl
    {
        private PatientController patientController;
        private BillingController billingController;
        BillingModel billingSummary;
        int selectedPatientID;
        public event EventHandler GoToDashboard;
        public BillingSummary()
        {
            InitializeComponent();
            patientController = new PatientController();
            billingController = new BillingController();
            selectedPatientID = GlobalVariables.selectedPatientID;
            billingSummary = GlobalVariables.billingSummary;
            LoadData();
        }
        private void LoadData()
        {
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(GlobalVariables.selectedPatientID);
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            decimal GrandTotal = 0;
            foreach (int admissionID in admissionIDs)
            {
                List<BillingDetailsModel> details = billingController.GetBillingDetails(admissionID);
                billingDetails.AddRange(details);
            }
            foreach (var detail in billingDetails)
            {
                GrandTotal += detail.Total;
            }
            billingDetails.Add(new BillingDetailsModel());
            billingDetails.Add(new BillingDetailsModel());
            billingDetails.Add(new BillingDetailsModel()
            {
                Total = GrandTotal
            });
            dataSummary.DataSource = billingDetails;
            dataSummary.Columns["AdmissionID"].Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            GoToDashboard?.Invoke(this, EventArgs.Empty);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
            GoToDashboard?.Invoke(this, EventArgs.Empty);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PatientModel patient = patientController.GetPatientByID(selectedPatientID);
            Graphics g = e.Graphics;

            g.DrawString("Bill Receipt", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));

            g.DrawString("Generated: " + DateTime.Now.ToString("MM/dd/yyyy"), new Font("Arial", 12), Brushes.Gray, new PointF(100, 90));

            g.DrawLine(Pens.Black, 100, 120, 700, 120);

            g.DrawString($"{patient.FirstName} {patient.MiddleName} {patient.LastName}", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new PointF(100, 140));
            g.DrawString($"Patient ID: {patient.PatientID}", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 170));
            g.DrawString(patient.Gender, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            g.DrawString($"{patient.Age} Years Old", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 230));


            g.DrawLine(Pens.Black, 100, 270, 700, 270);

            g.DrawString("Service/Item", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(100, 280));
            g.DrawString("Quantity/Days", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(350, 280));
            g.DrawString("Price", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(490, 280));
            g.DrawString("Total", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(600, 280));

            int y = 310;

            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(selectedPatientID);
            List<BillingDetailsModel> billingDetails = new List<BillingDetailsModel>();
            decimal GrandTotal = 0;
            foreach (int admissionID in admissionIDs)
            {
                List<BillingDetailsModel> details = billingController.GetBillingDetails(admissionID);
                billingDetails.AddRange(details);
            }
            foreach (var detail in billingDetails)
            {
                g.DrawString(detail.Service, new Font("Arial", 11), Brushes.Black, new PointF(100, y));
                g.DrawString(detail.Quantity.ToString(), new Font("Arial", 11), Brushes.Black, new PointF(400, y));
                g.DrawString($"₱{detail.Price}", new Font("Arial", 11), Brushes.Black, new PointF(500, y));
                g.DrawString($"₱{detail.Total}", new Font("Arial", 11), Brushes.Black, new PointF(600, y));
                y += 30;
                GrandTotal += detail.Total;
            }

            g.DrawLine(Pens.Black, 100, y, 700, y);
            g.DrawString("Total Amount:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 30));
            g.DrawString("Payment Received:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 60));
            g.DrawString("Remaining Balance:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 90));
            g.DrawString("Remarks:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 120));
            g.DrawString("₱" + billingSummary.TotalAmount.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 30));
            g.DrawString("₱" + billingSummary.AmountPaid.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 60));
            g.DrawString("₱" + billingSummary.Balance.ToString(), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 90));
            g.DrawString(billingSummary.Remarks, new Font("Arial", 14), Brushes.Black, new PointF(100, y + 150));
        }
    }
}