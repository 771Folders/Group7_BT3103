using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI
{
    public partial class FormDoctorAssignment : Form
    {
        PatientController patientController;
        StaffController staffController;
        PatientModel patient;
        List<int> assignStaffIDs;
        int selectedPatientID;
        string action;
        public FormDoctorAssignment()
        {
            patientController = new PatientController();
            staffController = new StaffController();
            selectedPatientID = FormMain.selectedPatientID;
            assignStaffIDs = FormMain.assignStaffIDs;
            patient = patientController.GetPatientByID(selectedPatientID);
            action = FormMain.assignAction;
            InitializeComponent();
            LoadData();
            CheckAssignedStaff();
        }
        private void LoadData()
        {
            labelPatientID.Text = $"Patient ID: {selectedPatientID.ToString()}";
            labelName.Text = $"Patient Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}";
            List<DoctorModel> doctors = staffController.GetAllDoctors();
            for (int i = 0; i < doctors.Count; i++)
            {
                cbDoctor1.Items.Add($"{doctors[i].FirstName} {doctors[i].LastName}");
                cbDoctor2.Items.Add($"{doctors[i].FirstName} {doctors[i].LastName}");
                cbDoctor3.Items.Add($"{doctors[i].FirstName} {doctors[i].LastName}");
            }
            List<NurseModel> nurses = staffController.GetAllNurses();
            for (int i = 0; i < nurses.Count; i++)
            {
                cbNurse1.Items.Add($"{nurses[i].FirstName} {nurses[i].FirstName}");
                cbNurse2.Items.Add($"{nurses[i].FirstName} {nurses[i].FirstName}");
                cbNurse3.Items.Add($"{nurses[i].FirstName} {nurses[i].FirstName}");
            }
        }
        private void CheckAssignedStaff()
        {
            ComboBox[] DoctorComboBoxes = { cbDoctor1, cbDoctor2, cbDoctor3 };
            ComboBox[] NurseComboBoxes = { cbNurse1, cbNurse2, cbNurse3 };
            List<AssignedStaffModel> staff = staffController.GetAssignedStaff(selectedPatientID);
            List<string> names = new List<string>();
            foreach (AssignedStaffModel member in staff)
            {
                string Name = $"{member.FirstName} {member.LastName}";
                if (names.Contains(Name))
                    continue;
                ComboBox[] boxes = member.Role == "Doctor" ? DoctorComboBoxes : NurseComboBoxes;
                foreach (ComboBox box in boxes)
                {
                    if (string.IsNullOrEmpty(box.Text))
                    {
                        box.SelectedItem = Name;
                        names.Add(Name);
                        break;
                    }
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            if (action.Equals("New"))
            {
                AssignToNewPatient();
            }
            else if (action.Equals("Old"))
            {
                AssignToOldPatient();
            }
        }
        private void AssignToOldPatient()
        {
            ComboBox[] boxes = { cbDoctor1, cbDoctor2, cbDoctor3, cbNurse1, cbNurse2, cbNurse3 };
            List<string> Staff = new List<string>();
            foreach (ComboBox box in boxes)
            {
                if (!string.IsNullOrWhiteSpace(box.Text))
                    Staff.Add(box.Text);
            }
            foreach (string name in Staff)
            {
                int staffID = staffController.GetStaffIDByName(name);
                staffController.AssignStaff(selectedPatientID, staffID);
            }
            MessageBox.Show("Staff assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void AssignToNewPatient()
        {
            ComboBox[] boxes = { cbDoctor1, cbDoctor2, cbDoctor3, cbNurse1, cbNurse2, cbNurse3 };
            List<string> Staff = new List<string>();
            foreach (ComboBox box in boxes)
            {
                Staff.Add(box.SelectedItem.ToString());
            }
            foreach (string name in Staff)
            {
                int staffID = staffController.GetStaffIDByName(name);
                FormMain.assignStaffIDs.Add(staffID);
            }
            MessageBox.Show("Staff assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
