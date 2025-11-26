using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.PopupForms
{
    public partial class FormDischargePatient : Form
    {
        PatientController patientController;
        List<PatientModel> patients;
        public event EventHandler GoToDischarge;
        public FormDischargePatient()
        {
            InitializeComponent();
            patientController = new PatientController();
            patients = patientController.GetAllPatients();
            txtPatientName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection list = new AutoCompleteStringCollection();
            foreach (PatientModel patient in patients)
            {
                if (!patient.Status.Equals("Discharged"))
                    list.Add($"{patient.FirstName} {patient.MiddleName} {patient.LastName}");
            }
            txtPatientName.AutoCompleteCustomSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPatientName.Text))
            {
                MessageBox.Show("Please enter the patient name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (patientController.SearchPatients(txtPatientName.Text).Count <= 0)
            {
                MessageBox.Show("Patient not found", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PatientModel patient = patientController.SearchPatients(txtPatientName.Text).First();
            GlobalVariables.selectedPatientID = patient.PatientID;
            DialogResult res = MessageBox.Show($"Are you sure you want to discharge {patient.FirstName} {patient.MiddleName} {patient.LastName}?", "Confirm Discharge", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                List<int> admissionIDs = patientController.GetPatientAdmissionIDs(GlobalVariables.selectedPatientID);
                List<AdmissionHistoryModel> admissions = patientController.GetAllAdmissionCards();
                int selectedAdmissionID = 0;
                foreach (AdmissionHistoryModel admission in admissions)
                {
                    if (admission.PatientID == GlobalVariables.selectedPatientID)
                        selectedAdmissionID = admission.AdmissionID;
                }
                patientController.DischargePatient(GlobalVariables.selectedPatientID, selectedAdmissionID);
                GoToDischarge?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Cancelled Discharging Patient", "Discharge Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
