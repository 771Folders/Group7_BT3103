using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Billing : UserControl
    {
        PatientController patientController;
        BillingController billingController;
        public event EventHandler GoToBillingSummary;
        public Billing()
        {
            InitializeComponent();
            patientController = new PatientController();
            billingController = new BillingController();
            LoadPatientData();
            LoadBillingDetails();
        }
        private void LoadPatientData()
        {
            PatientModel patient = patientController.GetPatientByID(GlobalVariables.selectedPatientID);
            lblPatientID.Text = $"Patient ID: {patient.PatientID.ToString()}";
            lblPatientName.Text = $"Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblGender.Text = $"Gender: {patient.Gender}";
            lblAge.Text = $"Age: {patient.DateOfBirth.ToString("MM/dd/yyyy")}";
        }
        private void LoadBillingDetails()
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
            dataGridView1.DataSource = billingDetails;
            dataGridView1.Columns["AdmissionID"].Visible = false;
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PatientModel patient = patientController.GetPatientByID(GlobalVariables.selectedPatientID);

            Graphics g = e.Graphics;

            g.DrawString("Billing Statement", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new PointF(100, 50));

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
                g.DrawString(detail.Service, new Font("Arial", 11), Brushes.Black, new PointF(100, y));
                g.DrawString(detail.Quantity.ToString(), new Font("Arial", 11), Brushes.Black, new PointF(400, y));
                g.DrawString($"₱{detail.Price}", new Font("Arial", 11), Brushes.Black, new PointF(500, y));
                g.DrawString($"₱{detail.Total}", new Font("Arial", 11), Brushes.Black, new PointF(600, y));
                y += 30;
                GrandTotal += detail.Total;
            }

            g.DrawLine(Pens.Black, 100, y + 20, 700, y + 20);
            g.DrawString("Total Amount:", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(100, y + 30));
            g.DrawString($"₱{GrandTotal}", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new PointF(580, y + 30));


            g.DrawString("End of Report", new Font("Arial", 10, FontStyle.Italic), Brushes.Gray, new PointF(100, y + 90));
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(GlobalVariables.selectedPatientID);
            BillPayment form = new BillPayment(admissionIDs[0]);
            form.GoToBillingSummary += (s, e) => GoToBillingSummary?.Invoke(this, EventArgs.Empty);
            form.ShowDialog();
        }
    }
}