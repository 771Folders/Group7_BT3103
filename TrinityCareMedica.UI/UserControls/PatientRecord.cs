using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class PatientRecord : UserControl
    {
        PatientController patientController;
        StaffController staffController;
        List<int> assignedStaffIDs;
        List<StaffModel> assignedStaff;
        int selectedPatientID;
        PatientModel patient;
        public PatientRecord()
        {
            InitializeComponent();

            patientController = new PatientController();
            staffController = new StaffController();
            selectedPatientID = GlobalVariables.selectedPatientID;
            patient = patientController.GetPatientByID(selectedPatientID);

            LoadAssignedStaff();
            LoadPatientData();
            LoadStaff();
        }
        private void LoadPatientData()
        {
            labelPatientID.Text = $"Patient ID: {patient.PatientID.ToString()}";
            labelDateRegistered.Text = $"Date Registered: {patient.DateRegistered.ToString("MMM/dd/yyyy")}";
            labelFullName.Text = $"Full Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}";
            labelDateOfBirth.Text = $"Date of Birth: {patient.DateOfBirth.ToString("MMM/dd/yyyy")}";
            labelAge.Text = $"Age: {patient.Age.ToString()}";
            labelGender.Text = $"Gender: {patient.Gender}";
            labelPhone.Text = $"Phone: {patient.Phone}";
            labelEmail.Text = $"Email: {patient.Email}";
            labelAddress.Text = $"Address: {patient.Address}";
            labelEmergencyContact.Text = $"Emergency Contact: {patient.EmergencyContact} ({patient.EmergencyContactPhone})";
        }
        private void LoadAssignedStaff()
        {
            assignedStaff = new List<StaffModel>();
            assignedStaffIDs = staffController.GetAssignedStaff(selectedPatientID);
            foreach (int staffID in assignedStaffIDs)
            {
                StaffModel staff = staffController.GetStaffByID(staffID);
                assignedStaff.Add(staff);
            }
        }
        private void LoadStaff()
        {
            txtDoctors.Clear();
            txtNurses.Clear();

            List<StaffModel> doctors = assignedStaff.Where(s => s.Role == "Doctor").ToList();
            List<StaffModel> nurses = assignedStaff.Where(s => s.Role == "Nurse").ToList();

            for (int i = 0; i < doctors.Count; i++)
            {
                StaffModel staff = doctors[i];
                txtDoctors.AppendText($"{staff.FirstName} {staff.LastName}");
                if (i < doctors.Count - 1)
                    txtDoctors.AppendText(", " + Environment.NewLine);
            }

            for (int i = 0; i < nurses.Count; i++)
            {
                StaffModel staff = nurses[i];
                txtNurses.AppendText($"{staff.FirstName} {staff.LastName}");
                if (i < nurses.Count - 1)
                    txtNurses.AppendText(", " + Environment.NewLine);
            }
        }

    }
}