using System;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI
{
    public partial class FormDoctorAssignment : Form
    {
        #region Local Variables
        PatientController patientController;
        StaffController staffController;
        PatientModel patient;
        List<int> assignStaffIDs;
        ComboBox[] boxes;
        int selectedPatientID;
        string action;
        #endregion
        public FormDoctorAssignment()
        {
            patientController = new PatientController();
            staffController = new StaffController();
            selectedPatientID = FormMain.selectedPatientID;
            assignStaffIDs = FormMain.assignStaffIDs;
            patient = patientController.GetPatientByID(selectedPatientID);
            action = FormMain.assignAction;
            InitializeComponent();
            SetBoxes();
            LoadData();
            CheckAssignedStaff();
        }
        private void SetBoxes()
        {
            boxes = new ComboBox[6];
            boxes[0] = cbDoctor1;
            boxes[1] = cbDoctor2;
            boxes[2] = cbDoctor3;
            boxes[3] = cbNurse1;
            boxes[4] = cbNurse2;
            boxes[5] = cbNurse3;
        }
        private void LoadData()
        {
            if (action.Equals("Old"))
            {
                labelPatientID.Text = $"Patient ID: {selectedPatientID.ToString()}";
                labelName.Text = $"Patient Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}";
            }
            else
            {
                labelPatientID.Text = patientController.GetNextPatientID().ToString(); 
                labelName.Visible = false ;
            }
            ComboBox[] doctorBoxes = { cbDoctor1, cbDoctor2, cbDoctor3 };
            ComboBox[] nurseBoxes = { cbNurse1, cbNurse2, cbNurse3 };
            List<DoctorModel> doctors = staffController.GetAllDoctors();
            foreach (ComboBox box in doctorBoxes)
            {
                box.Items.Add(string.Empty);
            }
            foreach (ComboBox box in nurseBoxes)
            {
                box.Items.Add(string.Empty);
            }
            for (int i = 0; i < doctors.Count; i++)
            {
               foreach (ComboBox box in doctorBoxes)
                {
                    box.Items.Add($"{doctors[i].FirstName} {doctors[i].LastName}");
                }
            }
            List<NurseModel> nurses = staffController.GetAllNurses();
            for (int i = 0; i < nurses.Count; i++)
            {
                foreach (ComboBox box in nurseBoxes)
                {
                    box.Items.Add($"{nurses[i].FirstName} {nurses[i].LastName}");
                }
            }
        }
        private void CheckAssignedStaff()
        {
            ComboBox[] DoctorComboBoxes = { cbDoctor1, cbDoctor2, cbDoctor3 };
            ComboBox[] NurseComboBoxes = { cbNurse1, cbNurse2, cbNurse3 };
            List<string> names = new List<string>();
            List<AssignedStaffModel> staff = staffController.GetAssignedStaff(selectedPatientID);
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
                        box.Text = Name;
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
            List<AssignedStaffModel> assignedStaff = staffController.GetAssignedStaff(selectedPatientID);
            staffController.DeleteAllAssignedStaff(selectedPatientID);
            List<string> Staff = new List<string>();
            List<string> assignedNames = new List<string>();
            foreach (AssignedStaffModel staff in assignedStaff)
            {
                assignedNames.Add($"{staff.FirstName} {staff.LastName}");
            }
            foreach (ComboBox box in boxes)
            {
                if (!string.IsNullOrWhiteSpace(box.Text))
                {
                        Staff.Add(box.Text);
                }
            }
            foreach (string name in Staff)
            {
                int staffID = staffController.GetStaffIDByName(name);
                staffController.AssignStaff(selectedPatientID, staffID);
            }
            MessageBox.Show("Staff assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void AssignToNewPatient()
        {
            List<string> Staff = new List<string>();
            foreach (ComboBox box in boxes)
            {
                if (!string.IsNullOrWhiteSpace(box.Text))
                    Staff.Add(box.SelectedItem.ToString());
            }
            foreach (string name in Staff)
            {
                int staffID = staffController.GetStaffIDByName(name);
                FormMain.assignStaffIDs.Add(staffID);
            }
            Close();
        }
        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            string name = box.Text;
            if (name != string.Empty)
            {
                foreach (ComboBox comboBox in boxes)
                {
                    if (comboBox.Name != box.Name && comboBox.Items.Contains(name))
                        comboBox.Items.Remove(name);
                }
            }
        }
    }
}
