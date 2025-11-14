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
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(GlobalVariables.selectedPatientID);
            patientController.DischargePatient(GlobalVariables.selectedPatientID, admissionIDs[0]);
            Close();
        }
    }
}
