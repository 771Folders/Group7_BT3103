using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Dashboard : UserControl
    {
        PatientController patientController;
        StaffController staffController;
        RoomController roomController;
        public event EventHandler GoToStaff;
        public event EventHandler GoToPatients;
        public event EventHandler GoToRooms;
        public Dashboard()
        {
            InitializeComponent();
            patientController = new PatientController();
            staffController = new StaffController();
            roomController = new RoomController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<PatientModel> patients = patientController.GetAllPatients();
            List<StaffModel> staff = staffController.GetAllStaff();
            List<StaffModel> doctors = new List<StaffModel>();
            List<StaffModel> nurses = new List<StaffModel>();
            List<RoomModel> rooms = roomController.GetAllRooms();
            int patientsAdmitted = 0;
            int roomNum = 0;
            foreach (PatientModel patient in patients)
            {
                if (patient.Status.Equals("Admitted"))
                {
                    patientsAdmitted++;
                }
            }
            foreach (StaffModel member in staff)
            {
                if (member.Role.Equals("Doctor"))
                {
                    doctors.Add(member);
                }
                else
                {
                    nurses.Add(member);
                }
            }
            foreach (RoomModel room in rooms)
            {
                roomNum += (room.Capacity);
            }
            lblPatientCount.Text = patientsAdmitted.ToString() + " Admitted";
            lblDoctorCount.Text = doctors.Count.ToString() + " Available";
            lblNursesCount.Text = nurses.Count.ToString() + " Available";
            lblRoomCount.Text = roomNum + " Available";
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
