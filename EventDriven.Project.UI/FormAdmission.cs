using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormAdmission : Form
    {
        PatientController patientController;
        public FormAdmission()
        {
            InitializeComponent();
            CheckLoggedUser();
            patientController = new PatientController();
            if (FormPatientInformationMaintenance.action.Equals("Add"))
            {
                label1.Text = "Patient Admission";
                btnSubmit.Text = "ADMIT";
                checkboxTandC.Visible = true;
                label20.Visible = true;
                label18.Visible = true;
                btnReset.Visible = true;
                button3.BackColor = Color.Transparent;
                button2.BackColor = Color.White;
                txtPatientID.Text = AutoPatientID().ToString();
            }
            else if (FormPatientInformationMaintenance.action.Equals("Edit"))
            {
                FillFields();
                label1.Text = "Edit Patient Information";
                btnSubmit.Text = "SAVE";
                checkboxTandC.Visible = false;
                label20.Visible = false;
                label18.Visible = false;
                btnReset.Visible = false;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.White;
            }
        }

        private int AutoPatientID()
        {
            return patientController.GetNextPatientID();
        }

        private void FillFields()
        {
            PatientModel patient = patientController.GetPatientByID(FormPatientInformationMaintenance.selectedPatientID);
            txtPatientID.Text = patient.PatientID.ToString();
            txtLastName.Text = patient.LastName;
            txtFirstName.Text = patient.FirstName;
            txtMiddleName.Text = patient.MiddleName;
            dateDOB.Value = patient.DateOfBirth;
            drpdownGender.Text = patient.Gender;
            txtAddress.Text = patient.Address;
            txtEmail.Text = patient.Email;
            txtPhone.Text = patient.Phone;
            txtGuardian.Text = patient.EmergencyContact;
            txtGuardianPhone.Text = patient.EmergencyContactPhone;
            dateAdmissionDate.Value = patient.DateRegistered;
        }

        private void CheckLoggedUser()
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    break;
                case "Doctor":
                    button2.Visible = false;
                    button4.Visible = false;
                    break;
                case "Nurse":
                    button2.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                    break;
                case "Cashier":
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    break;
                case "Receptionist":
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInformationMaintenance formPatientInformationMaintenance = new FormPatientInformationMaintenance();
            formPatientInformationMaintenance.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                PatientModel patient = new PatientModel()
                {
                    PatientID = int.Parse(txtPatientID.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    DateOfBirth = dateDOB.Value.Date,
                    Gender = drpdownGender.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    EmergencyContact = txtGuardian.Text,
                    EmergencyContactPhone = txtGuardianPhone.Text,
                    DateRegistered = dateAdmissionDate.Value.Date
                };
                if (FormPatientInformationMaintenance.action.Equals("Add"))
                {
                    if (checkboxTandC.Checked == true)
                    {
                        patientController.AddPatient(patient);
                        MessageBox.Show("Patient admitted successfully.");

                        ResetBtn();
                    }
                    else
                    {
                        MessageBox.Show("Please agree to the terms and conditions.", "Terms and Conditions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (FormPatientInformationMaintenance.action.Equals("Edit"))
                {
                    patientController.EditPatient(patient);
                    MessageBox.Show("Patient information updated successfully.");
                    FormPatientInformationMaintenance formPatientInformationMaintenance = new FormPatientInformationMaintenance();
                    formPatientInformationMaintenance.ShowDialog();
                    Hide();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetBtn();
        }

        private void ResetBtn()
        {
            txtPatientID.Text = AutoPatientID().ToString();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            dateDOB.Value = DateTime.Today;
            drpdownGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            txtGuardian.Clear();
            txtGuardianPhone.Clear();
            txtAddress.Clear();
            checkboxTandC.Checked = false;
            dateAdmissionDate.Value = DateTime.Today;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormPatientInformationMaintenance formPatientInformationMaintenance = new FormPatientInformationMaintenance();
            formPatientInformationMaintenance.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPatientInformationMaintenance.action = "Add";
            Hide();
            FormAdmission formAdmission = new FormAdmission();
            formAdmission.ShowDialog();
        }
    }
}
