using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI.UserControls
{
    public partial class Admission : UserControl
    {
        #region Local Variables
        PatientController patientController;
        String action;
        public event EventHandler GoToDashboard;
        public event EventHandler GoToPatientInfo;
        #endregion
        public Admission()
        {
            InitializeComponent();
            patientController = new PatientController();
            action = FormMain.admissionAction;
            lblID.Text = patientController.GetNextPatientID().ToString();
            CheckAction();
        }

        private void CheckAction()
        {
            if (action == "Add")
            {
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
            PatientModel patient = patientController.GetPatientByID(FormMain.selectedPatientID);
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
            dateAdmissionDate.Value = patient.DateRegistered;
        }

        private void Reset()
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
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                PatientModel patient = new PatientModel()
                {
                    PatientID = int.Parse(lblID.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    DateOfBirth = dateBirth.Value.Date,
                    Gender = drpdownGender.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    EmergencyContact = txtGuardian.Text,
                    EmergencyContactPhone = txtGuardianPhone.Text,
                    DateRegistered = dateAdmissionDate.Value.Date
                };
                if (action.Equals("Add"))
                {
                    if (checkboxTandC.Checked == true)
                    {
                        patientController.AddPatient(patient);
                        MessageBox.Show("Patient admitted successfully.");
                        Reset();
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
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}