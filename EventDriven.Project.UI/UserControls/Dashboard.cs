using EventDriven.Project.Businesslogic.Controller;

namespace EventDriven.Project.UI.UserControls
{
    public partial class Dashboard : UserControl
    {
        PatientController patientController;
        public event EventHandler GoToPatients;
        public Dashboard()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblPatientCount.Text = patientController.GetAllPatients().Count.ToString() + "\nAdmitted";
        }

        private void panelDoctors_MouseEnter(object sender, EventArgs e)
        {
            panelDoctors.BorderThickness = 2;
        }

        private void panelDoctors_MouseLeave(object sender, EventArgs e)
        {
            panelDoctors.BorderThickness = 0;
        }

        private void panelPatients_MouseEnter(object sender, EventArgs e)
        {
            panelPatients.BorderThickness = 2;
        }

        private void panelPatients_MouseLeave(object sender, EventArgs e)
        {
            panelPatients.BorderThickness = 0;
        }

        private void panelNurses_MouseEnter(object sender, EventArgs e)
        {
            panelNurses.BorderThickness = 2;
        }

        private void panelNurses_MouseLeave(object sender, EventArgs e)
        {
            panelNurses.BorderThickness = 0;
        }

        private void panelRooms_MouseEnter(object sender, EventArgs e)
        {
            panelRooms.BorderThickness = 2;
        }

        private void panelRooms_MouseLeave(object sender, EventArgs e)
        {
            panelRooms.BorderThickness = 0;
        }

        private void panelPatients_Click(object sender, EventArgs e)
        {
            GoToPatients?.Invoke(this, EventArgs.Empty);
        }
    }
}
