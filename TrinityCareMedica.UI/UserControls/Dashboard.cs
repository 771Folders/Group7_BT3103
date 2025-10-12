using TrinityCareMedica.Businesslogic.Controller;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Dashboard : UserControl
    {
        PatientController patientController;
        RoomController roomController;
        StaffController staffController;
        public event EventHandler GoToStaff;
        public event EventHandler GoToPatients;
        public event EventHandler GoToRooms;
        public Dashboard()
        {
            InitializeComponent();
            patientController = new PatientController();
            roomController = new RoomController();
            staffController = new StaffController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblDoctorCount.Text = $"{staffController.GetAllDoctors().Count.ToString()} Doctors";
            lblNursesCount.Text = $"{staffController.GetAllNurses().Count.ToString()} Nurses";
            lblPatientCount.Text = $"{patientController.GetAllPatients().Count.ToString()} Admitted";
            lblRoomCount.Text = $"{roomController.GetAllRooms().Count.ToString()} Available";
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
