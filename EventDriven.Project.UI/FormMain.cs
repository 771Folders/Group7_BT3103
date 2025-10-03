using EventDriven.Project.UI.UserControls;

namespace EventDriven.Project.UI
{
    public partial class FormMain : Form
    {
        public static string admissionAction = "Add";
        public static int selectedPatientID = 0;
        public FormMain()
        {
            InitializeComponent();
            ShowControl(new Dashboard());
            CheckLoggedUser();
        }
        private void CheckLoggedUser()
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    btnAdmission.Visible = true;
                    btnPatientInfo.Visible = true;
                    btnBilling.Visible = true;
                    break;
                case "Doctor":
                    btnAdmission.Visible = false;
                    btnPatientInfo.Visible = true;
                    btnBilling.Visible = false;
                    break;
                case "Nurse":
                    btnAdmission.Visible = false;
                    btnPatientInfo.Visible = true;
                    btnBilling.Visible = false;
                    break;
                case "Receptionist":
                    btnAdmission.Visible = true;
                    btnPatientInfo.Visible = true;
                    btnBilling.Visible = false;
                    break;
                case "Cashier":
                    btnAdmission.Visible = false;
                    btnPatientInfo.Visible = false;
                    btnBilling.Visible = true;
                    break;
            }
        }
        
        private void ShowControl(UserControl control)
        {
            btnDashboard.BackColor = Color.Transparent;
            btnPatientInfo.BackColor = Color.Transparent;
            btnAdmission.BackColor = Color.Transparent;
            btnBilling.BackColor = Color.Transparent;
            control.Dock = DockStyle.Fill;

            if (control is Dashboard dashboard)
            {
                btnDashboard.BackColor = Color.White;
                dashboard.GoToPatients += (s, e) => ShowControl(new PatientInformationMaintenance());
            }
            else if (control is PatientInformationMaintenance pim)
            {
                btnPatientInfo.BackColor = Color.White;
                pim.GoToDashboard += (s, e) => ShowControl(new Dashboard());
                pim.GoToAddPatient += (s, e) =>
                {
                    admissionAction = "Add";
                    ShowControl(new Admission());
                };
                pim.GoToEditPatient += (s, e) =>
                {
                    admissionAction = "Edit";
                    ShowControl(new Admission());
                };
            }
            else if (control is Admission admission)
            {
                if (admissionAction == "Add")
                {
                    btnAdmission.BackColor = Color.White;
                }
                else if (admissionAction == "Edit")
                {
                    btnPatientInfo.BackColor = Color.White;
                }
                admission.GoToDashboard += (s, e) => ShowControl(new Dashboard());
                admission.GoToPatientInfo += (s, e) => ShowControl(new PatientInformationMaintenance());
            }

            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
        }

        private void Pim_GoToDashboard(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #region Sidebar Button Events
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowControl(new Dashboard());
        }

        private void btnPatientInfo_Click(object sender, EventArgs e)
        {
            ShowControl(new PatientInformationMaintenance());
        }

        private void btnAdmission_Click(object sender, EventArgs e)
        {
            ShowControl(new Admission());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            Hide();
        }
        #endregion
    }
}