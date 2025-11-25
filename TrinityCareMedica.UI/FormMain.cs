using TrinityCareMedica.UI.AssignmentForms;
using TrinityCareMedica.UI.PopupForms;
using TrinityCareMedica.UI.UserControls;

namespace TrinityCareMedica.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            DoubleBuffering();
            ShowControl(new Dashboard());
            CheckLoggedUser();
        }
        private void DoubleBuffering()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.UserPaint |
              ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                panelMain,
                new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                panelAppTitle,
                new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                panelSideBar,
                new object[] { true });
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                flowPanelSideBar,
                new object[] { true });
        }
        private void CheckLoggedUser()
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    btnAdmission.Visible = true;
                    btnBilling.Visible = true;
                    btnDischarge.Visible = true;
                    break;
                case "Doctor":
                    btnAdmission.Visible = false;
                    btnBilling.Visible = false;
                    btnDischarge.Visible = false;
                    break;
                case "Nurse":
                    btnAdmission.Visible = false;
                    btnBilling.Visible = false;
                    btnDischarge.Visible = false;
                    break;
                case "Receptionist":
                    btnAdmission.Visible = true;
                    btnBilling.Visible = false;
                    btnDischarge.Visible = true;
                    break;
                case "Cashier":
                    btnAdmission.Visible = false;
                    btnBilling.Visible = true;
                    btnDischarge.Visible = false;
                    break;
            }
        }
        private void ShowControl(UserControl control)
        {
            btnDashboard.BackColor = Color.Transparent;
            btnPatientInfo.BackColor = Color.Transparent;
            btnAdmission.BackColor = Color.Transparent;
            btnPatientInfo.BackColor = Color.Transparent;
            btnBilling.BackColor = Color.Transparent;
            btnDischarge.BackColor = Color.Transparent;
            control.Dock = DockStyle.Fill;

            if (control is Dashboard dashboard)
            {
                btnDashboard.BackColor = Color.White;
                dashboard.GoToPatients += (s, e) => ShowControl(new PatientInformationMaintenance());
                dashboard.GoToStaff += (s, e) => ShowControl(new StaffList());
                dashboard.GoToRooms += (s, e) => ShowControl(new Rooms());
            }
            else if (control is PatientInformationMaintenance pim)
            {
                btnPatientInfo.BackColor = Color.White;
                pim.GoToDashboard += (s, e) => ShowControl(new Dashboard());
                pim.GoToAddPatient += (s, e) =>
                {
                    GlobalVariables.admissionAction = "Add";
                    ShowControl(new Admission());
                };
                pim.GoToEditPatient += (s, e) =>
                {
                    GlobalVariables.admissionAction = "Edit";
                    ShowControl(new Admission());
                };
                pim.GoToPatientRecord += (s, e) => ShowControl(new PatientRecord());
                pim.GoToDischarge += (s, e) => ShowControl(new Discharge());
                pim.GoToBilling += (s, e) => ShowControl(new Billing());
                pim.GoToBillingSummary += (s, e) => ShowControl(new BillingSummary());
            }
            else if (control is Admission admission)
            {
                if (GlobalVariables.admissionAction == "Add")
                {
                    btnAdmission.BackColor = Color.White;
                }
                else if (GlobalVariables.admissionAction == "Edit")
                {
                    btnPatientInfo.BackColor = Color.White;
                }
                admission.GoToDashboard += (s, e) => ShowControl(new Dashboard());
                admission.GoToPatientInfo += (s, e) => ShowControl(new PatientInformationMaintenance());
            }
            else if (control is PatientRecord patientRecord)
            {
                btnPatientInfo.BackColor = Color.White;
            }
            else if (control is Billing billing)
            {
                btnBilling.BackColor = Color.White;
                billing.GoToBillingSummary += (s, e) => ShowControl(new BillingSummary());
            }
            else if (control is Discharge discharge)
            {
                btnDischarge.BackColor = Color.White;
            }
            else if (control is BillingSummary billingSummary)
            {
                btnBilling.BackColor = Color.White;
                billingSummary.GoToDashboard += (s, e) => ShowControl(new Dashboard());
            }

            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
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
            GlobalVariables.admissionAction = "Add";
            ShowControl(new Admission());
        }
        private void btnBilling_Click(object sender, EventArgs e)
        {
            FormSelectPatient form = new FormSelectPatient();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                ShowControl(new Billing());
            }
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowControl(new StaffList());
        }
        private void btnRooms_Click(object sender, EventArgs e)
        {
            ShowControl(new Rooms());
        }
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            FormDischargePatient form = new FormDischargePatient();
            form.GoToDischarge += (s, e) => ShowControl(new Discharge());
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                ShowControl(new Discharge());
            }
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