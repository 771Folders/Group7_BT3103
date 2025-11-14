using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCareMedica.Model;
using TrinityCareMedica.Businesslogic.Controller;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Billing : UserControl
    {
        private PatientController patientController;
        // For demonstration, using a sample patient; in real use, load from selection or input
        private PatientModel samplePatient;
        private DateTime timeAdmitted;
        private DateTime timeOut;
        private decimal price;

        public Billing()
        {
            InitializeComponent();
            patientController = new PatientController();
            LoadSamplePatient();
        }

        private void LoadSamplePatient()
        {
            // Load a sample patient for demonstration (e.g., first patient or by ID)
            var patients = patientController.GetAllPatients();
            if (patients != null && patients.Count > 0)
            {
                samplePatient = patients[0]; // Or use GetPatientByID(1) for a specific one
            }
            else
            {
                // Fallback sample if no patients
                samplePatient = new PatientModel
                {
                    PatientID = 1,
                    FirstName = "John",
                    MiddleName = "Doe",
                    LastName = "Smith",
                    // Add other fields as needed
                };
            }
            // Sample billing data
            timeAdmitted = DateTime.Now.AddDays(-1);
            timeOut = DateTime.Now;
            price = 150.00m;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Professional layout
            Graphics g = e.Graphics;
            Font titleFont = new Font("Arial", 18, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 10, FontStyle.Regular);
            Brush brush = Brushes.Black;
            int yPosition = 100;
            int leftMargin = 100;

            // Title
            string title = "TrinityCare Medica Billing Statement";
            SizeF titleSize = g.MeasureString(title, titleFont);
            g.DrawString(title, titleFont, brush, (e.PageBounds.Width - titleSize.Width) / 2, yPosition);
            yPosition += (int)titleSize.Height + 20;

            // Patient Info Header
            g.DrawString("Patient Information", headerFont, brush, leftMargin, yPosition);
            yPosition += 30;

            // Patient Details
            g.DrawString($"Patient ID: {samplePatient.PatientID}", bodyFont, brush, leftMargin, yPosition);
            yPosition += 20;
            g.DrawString($"Name: {samplePatient.FirstName} {samplePatient.MiddleName} {samplePatient.LastName}", bodyFont, brush, leftMargin, yPosition);
            yPosition += 20;
            g.DrawString($"Time Admitted: {timeAdmitted.ToString("g")}", bodyFont, brush, leftMargin, yPosition);
            yPosition += 20;
            g.DrawString($"Time Out: {timeOut.ToString("g")}", bodyFont, brush, leftMargin, yPosition);
            yPosition += 20;
            g.DrawString($"Total Price: ${price:F2}", bodyFont, brush, leftMargin, yPosition);
            yPosition += 40;

            // Footer
            g.DrawString("Thank you for choosing TrinityCare Medica.", bodyFont, brush, leftMargin, yPosition);
            yPosition += 20;
            g.DrawString($"Printed on: {DateTime.Now.ToString("g")}", bodyFont, brush, leftMargin, yPosition);
        }
    }
}
