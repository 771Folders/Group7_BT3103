using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;
using TrinityCareMedica.UI.AssignmentForms;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Admission : UserControl
    {
        #region Local Variables
        PatientController patientController;
        StaffController staffController;
        RoomController roomController;
        String action;
        public event EventHandler GoToDashboard;
        public event EventHandler GoToPatientInfo;
        #endregion
        public Admission()
        {
            InitializeComponent();
            patientController = new PatientController();
            staffController = new StaffController();
            roomController = new RoomController();
            action = GlobalVariables.admissionAction;
            lblID.Text = patientController.GetNextPatientID().ToString();
            CheckAction();
        }
        private void CheckAction()
        {
            if (action == "Add")
            {
                GlobalVariables.selectedPatientID = patientController.GetNextPatientID();
                labelTitle.Text = "Patient Admission";
                btnSubmit.Text = "ADMIT";
                btnReset.Text = "RESET";
                checkboxTandC.Visible = true;
                label20.Visible = true;
                label18.Visible = true;
            }
            else if (action == "Edit")
            {
                FillFields();
                labelTitle.Text = "Edit Patient Information";
                btnSubmit.Text = "SAVE";
                btnReset.Text = "CANCEL";
                checkboxTandC.Visible = false;
                label20.Visible = false;
                label18.Visible = false;
            }
        }
        private void FillFields()
        {
            PatientModel patient = patientController.GetPatientByID(GlobalVariables.selectedPatientID);
            lblID.Text = patient.PatientID.ToString();
            txtLastName.Text = patient.LastName;
            txtFirstName.Text = patient.FirstName;
            txtMiddleName.Text = patient.MiddleName;
            dateBirth.Value = patient.DateOfBirth;
            drpdownGender.Text = patient.Gender;
            txtAddress.Text = patient.Address;
            txtEmail.Text = patient.Email;
            txtPhone.Text = patient.Phone;
            txtGuardian.Text = patient.EmergencyContact;
            txtGuardianPhone.Text = patient.EmergencyContactPhone;
        }
        private void Reset()
        {
            lblID.Text = patientController.GetNextPatientID().ToString();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            dateBirth.Value = DateTime.Today;
            drpdownGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtGuardian.Clear();
            txtGuardianPhone.Clear();
            txtAddress.Clear();
            checkboxTandC.Checked = false;
            dateAdmissionDate.Value = DateTime.Today;
            GlobalVariables.assignedStaff.Clear();
            GlobalVariables.assignedRoom = new AssignedRoomModel();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text)
                    || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(drpdownGender.Text))
                {
                    MessageBox.Show("Please fill in the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtEmail.Text.Length > 0 && !txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PatientModel patient = new PatientModel()
                {
                    PatientID = int.Parse(lblID.Text),
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    MiddleName = txtMiddleName.Text.Trim(),
                    DateOfBirth = dateBirth.Value.Date,
                    Age = calculateAge(),
                    Gender = drpdownGender.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    EmergencyContact = txtGuardian.Text.Trim(),
                    EmergencyContactPhone = txtGuardianPhone.Text.Trim()
                };
                if (action.Equals("Add"))
                {
                    if (checkboxTandC.Checked == true)
                    {
                        patientController.AddPatient(patient);
                        MessageBox.Show("Patient admitted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Please agree to the terms and conditions.", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (action.Equals("Edit"))
                {
                    patientController.EditPatient(patient);
                    MessageBox.Show("Patient information updated successfully.");
                    GoToPatientInfo?.Invoke(this, EventArgs.Empty);
                }
                if (GlobalVariables.assignedStaff.Count > 0)
                {
                    foreach (StaffModel assigned in GlobalVariables.assignedStaff)
                    {
                        staffController.AssignStaff(GlobalVariables.selectedPatientID, assigned.StaffID);
                    }
                }
                if (!string.IsNullOrEmpty(GlobalVariables.assignedRoom.RoomType))
                {
                    GlobalVariables.assignedRoom.PatientID = GlobalVariables.selectedPatientID;
                    roomController.AssignRoom(GlobalVariables.assignedRoom);
                }
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (action.Equals("Edit"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the changes?", "Cancel Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    GoToPatientInfo?.Invoke(this, EventArgs.Empty);
                    return;
                }
            }
            else if (action.Equals("Add"))
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset all fields?", "Reset All Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Reset();
                }
            }
        }
        private void checkboxTandC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                checkboxTandC.Checked = !checkboxTandC.Checked;
            }
        }
        private int calculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateBirth.Value.Year;
            if (dateBirth.Value.Date > today.AddYears(-age)) age--;
            return age;
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            FormAssignStaff form = new FormAssignStaff();
            form.ShowDialog();
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            FormAssignRoom form = new FormAssignRoom();
            form.ShowDialog();
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '+' && e.KeyChar != '(' && e.KeyChar != ')')
            {
                e.Handled = true;
            }
        }
    }
}