using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Discharge : UserControl
    {
        PatientController patientController;
        public Discharge()
        {
            InitializeComponent();
            patientController = new PatientController();
            LoadData();
        }
        private void LoadData()
        {
            PatientModel patient = patientController.GetPatientByID(GlobalVariables.selectedPatientID);
            List<int> admissionIDs = patientController.GetPatientAdmissionIDs(GlobalVariables.selectedPatientID);
            List<AdmissionHistoryModel> admissionHistory = patientController.GetAllAdmissionCards();
            AdmissionHistoryModel admission = admissionHistory[0];
            lblPatientName.Text = admission.PatientName;
            lblPatientID.Text = admission.PatientID.ToString();
            lblAdmissionDate.Text = admission.AdmissionDate.ToShortDateString();
            lblDischargeDate.Text = admission.DischargeDate.ToString();
            lblDiagnosis.Text = admission.Diagnosis;
        }
    }
}
