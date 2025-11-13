using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class PatientRecord : UserControl
    {
        PatientController patientController;
        StaffController staffController;
        RoomController roomController;
        List<int> assignedStaffIDs;
        List<StaffModel> assignedStaff;
        int selectedPatientID;
        PatientModel patient;
        AssignedRoomModel assignedRoom;
        public PatientRecord()
        {
            InitializeComponent();

            patientController = new PatientController();
            staffController = new StaffController();
            roomController = new RoomController();
            selectedPatientID = GlobalVariables.selectedPatientID;
            patient = patientController.GetPatientByID(selectedPatientID);
            assignedRoom = GlobalVariables.assignedRoom;
            assignedStaff = GlobalVariables.assignedStaff;

            CheckDischargeStatus();
            LoadPatientData();
            LoadStaff();
            LoadRoom();
        }
        private void LoadPatientData()
        {
            labelPatientID.Text = $"Patient ID: {patient.PatientID.ToString()}";
            labelFullName.Text = $"Full Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}";
            labelDateOfBirth.Text = $"Date of Birth: {patient.DateOfBirth.ToString("MMM/dd/yyyy")}";
            labelAge.Text = $"Age: {patient.Age.ToString()}";
            labelGender.Text = $"Gender: {patient.Gender}";
            labelPhone.Text = $"Phone: {patient.Phone}";
            labelEmail.Text = $"Email: {patient.Email}";
            labelAddress.Text = $"Address: {patient.Address}";
            labelEmergencyContact.Text = $"Emergency Contact: {patient.EmergencyContact} ({patient.EmergencyContactPhone})";
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
        private void LoadRoom()
        {
            if (!string.IsNullOrEmpty(assignedRoom.RoomType))
            {
                labelRoom.Text = $"Current Room: {assignedRoom.RoomType} ({assignedRoom.RoomNumber})";
                labelBedNo.Text = $"Bed Number: {assignedRoom.BedNumber}";
                labelStartDate.Text = $"Start Date: {assignedRoom.StartDate.ToString("MMM/dd/yyyy")}";
                labelEndDate.Text = assignedRoom.EndDate.HasValue ? $"End Date: {assignedRoom.EndDate.Value.ToString("MMM/dd/yyyy")}" : "End Date: N/A";
            }
            else
            {
                labelRoom.Text = "Not Assigned to a Room";
                labelBedNo.Visible = false;
                labelStartDate.Visible = false;
                labelEndDate.Visible = false;
            }
        }
        private void CheckDischargeStatus()
        {
            if (patient.Status.Equals("Discharged"))
            {
                panelDischarged.Visible = true;
                panelRoomAndStaff.Visible = false;
            }
            else
            {
                panelDischarged.Visible = false;
                panelRoomAndStaff.Visible = true;
            }
        }
    }
}