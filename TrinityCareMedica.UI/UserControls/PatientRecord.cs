using System.Data.SqlTypes;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class PatientRecord : UserControl
    {
        #region Local Variables
        PatientController patientController;
        RoomController roomController;
        StaffController staffController;
        MedicalRecordController medicalRecordController;
        PatientModel patient;
        PatientRoomModel room;
        List<AssignedStaffModel> assignedStaff;
        #endregion
        public PatientRecord()
        {
            patientController = new PatientController();
            roomController = new RoomController();
            staffController = new StaffController();
            medicalRecordController = new MedicalRecordController();
            patient = patientController.GetPatientByID(FormMain.selectedPatientID);
            room = new PatientRoomModel();
            assignedStaff = new List<AssignedStaffModel>();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LoadPatientInfo();
            LoadRoomInfo();
            LoadDoctors();
            LoadMedicalRecords();
        }
        private void LoadPatientInfo()
        {
            lblPatientID.Text = $"Patient ID: {patient.PatientID.ToString()}";
            lblAdmissionDate.Text = $"Date Admitted: {patient.DateRegistered}";
            lblName.Text = $"{patient.FirstName} {patient.MiddleName} {patient.LastName}";
            lblGender.Text = $"Gender: {patient.Gender}";
            lblDateOfBirth.Text = $"Date of Birth: {patient.DateOfBirth.ToShortDateString()}";
            lblPhone.Text = $"Phone: {patient.Phone}";
            lblEmail.Text = $"Email: {patient.Email}";
            lblAddress.Text = $"Address: {patient.Address}";
            lblEmergencyContact.Text = $"Emergency Contact: {patient.EmergencyContact}";
            lblEmergencyContactPhone.Text = $"Emergency Contact Phone: {patient.EmergencyContactPhone}";
        }
        private void LoadRoomInfo()
        {
            try
            {
                if (roomController.GetRoomByPatientID(patient.PatientID) != null)
                {
                    room = roomController.GetRoomByPatientID(patient.PatientID);
                    lblRoom.Text = $"Current Room: {room.RoomType} ({room.RoomNumber})";
                    lblBedNo.Text = $"Bed Number: {room.BedNumber}";
                    lblStartDate.Text = $"From: {room.StartDate.ToShortDateString()}";
                    lblEndDate.Text = $"To: {(room.EndDate.HasValue ? room.EndDate.Value.ToShortDateString() : "N/A")}";
                }
            }
            catch (SqlTypeException)
            {
                lblRoom.Text = "N/A";
                lblBedNo.Visible = false;
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
            }
        }
        private void LoadDoctors()
        {
            textboxDoctors.Clear();
            textboxNurses.Clear();
            assignedStaff = staffController.GetAssignedStaff(patient.PatientID);
            List<AssignedStaffModel> doctors = new List<AssignedStaffModel>();
            List<AssignedStaffModel> nurses = new List<AssignedStaffModel>();

            for (int i = 0; i < assignedStaff.Count; i++)
            {
                if (assignedStaff[i].Role.Equals("Doctor"))
                    doctors.Add(assignedStaff[i]);
                else if (assignedStaff[i].Role.Equals("Nurse"))
                    nurses.Add(assignedStaff[i]);
            }

            if (doctors.Count == 0)
                textboxDoctors.Text = "None";
            if (nurses.Count == 0)
                textboxNurses.Text = "None";

            for (int i = 0; i < assignedStaff.Count; i++)
            {
                if (assignedStaff[i].Role.Equals("Doctor"))
                {
                    textboxDoctors.AppendText($"{assignedStaff[i].FirstName} {assignedStaff[i].LastName}");
                    if (i < doctors.Count - 1)
                        textboxDoctors.AppendText(", ");
                }
                else if (assignedStaff[i].Role.Equals("Nurse"))
                {
                    textboxNurses.AppendText($"{assignedStaff[i].FirstName} {assignedStaff[i].LastName}");
                    if (i == nurses.Count - 1)
                        textboxNurses.AppendText(", ");
                }
            }
        }
        private void LoadMedicalRecords()
        {
            try
            {
                flowMedicalRecords.Controls.Clear();
                int records = medicalRecordController.GetMedicalRecordCards(patient.PatientID).Count;
                for (int i = 0; i < records; i++)
                {
                    MedicalRecordCard card = new MedicalRecordCard(i);
                    flowMedicalRecords.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormMain.assignAction = "Old";
            FormDoctorAssignment doctorAssignment = new FormDoctorAssignment();
            doctorAssignment.ShowDialog();
            if (doctorAssignment.DialogResult == DialogResult.OK)
            {
                LoadDoctors();
            }
        }
        private void buttonTransferRoom_Click(object sender, EventArgs e)
        {
            FormMain.assignAction = "Old";
            FormRoomAssignment roomAssignment = new FormRoomAssignment();
            roomAssignment.ShowDialog();
            if (roomAssignment.DialogResult == DialogResult.OK)
            {
                LoadRoomInfo();
            }
        }
    }
}
