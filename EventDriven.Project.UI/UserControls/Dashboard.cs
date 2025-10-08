using EventDriven.Project.Businesslogic.Controller;

namespace EventDriven.Project.UI.UserControls
{
    public partial class Dashboard : UserControl
    {
        PatientController patientController;
        public event EventHandler GoToStaff;
        public event EventHandler GoToPatients;
        public event EventHandler GoToRooms;
        public Dashboard()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblPatientCount.Text = patientController.GetAllPatients().Count.ToString() + "\nAdmitted";
        }

        private void panelPatients_Click(object sender, EventArgs e)
        {
            GoToPatients?.Invoke(this, EventArgs.Empty);
        }

        private void panelStaff_Click(object sender, EventArgs e)
        {
            GoToStaff?.Invoke(this, EventArgs.Empty);
        }

        private void panelRooms_Click(object sender, EventArgs e)
        {
            GoToRooms?.Invoke(this, EventArgs.Empty);
        }
    }
}
