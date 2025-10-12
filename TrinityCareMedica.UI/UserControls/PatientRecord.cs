using System.Data.SqlTypes;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class PatientRecord : UserControl
    {
        PatientController patientController;
        RoomController roomController;
        StaffController staffController;
        MedicalRecordController medicalRecordController;
        PatientModel patient;
        PatientRoomModel room;
        List<AssignedStaffModel> assignedStaff;
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
            lblDateOfBirth.Text = $"Date of Birth: {patient.DateOfBirth.Date}";
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
                room = roomController.GetRoomByPatientID(patient.PatientID);
                lblRoom.Text = $"Current Room: {room.RoomType} ({room.RoomNumber})";
                lblBedNo.Text = $"Bed Number: {room.BedNumber}";
                lblStartDate.Text = $"From: {room.StartDate.Date}";
                lblEndDate.Text = $"To: {room.EndDate.Date}";
            }
            catch (SqlTypeException)
            {
                lblBedNo.Visible = false;
                lblStartDate.Visible = false;
                lblEndDate.Visible = false;
            }
        }
        private void LoadDoctors()
        {
            assignedStaff = staffController.GetAssignedStaff(patient.PatientID);
            for (int i = 0; i < assignedStaff.Count; i++)
            {
                if (assignedStaff[i].Role.Equals("Doctor"))
                {
                    if(i == assignedStaff.Count - 1)
                        textboxDoctors.AppendText($"{assignedStaff[i].FirstName} {assignedStaff[i].LastName}");
                    else
                        textboxDoctors.AppendText($"{assignedStaff[i].FirstName} {assignedStaff[i].LastName}, \n");
                }
                else if (assignedStaff[i].Role.Equals("Nurse"))
                {
                    if (i == assignedStaff.Count - 1)
                        textboxNurses.AppendText($"{assignedStaff[i].FirstName} {assignedStaff[i].LastName}");
                    else
                        textboxNurses.AppendText($"{assignedStaff[i].FirstName} {assignedStaff[i].LastName}, \n");
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
    }
}
