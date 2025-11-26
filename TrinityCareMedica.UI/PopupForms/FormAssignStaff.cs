using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI
{
    public partial class FormAssignStaff : Form
    {

        PatientController patientController;
        StaffController staffController;
        ComboBox[] doctorBoxes;
        ComboBox[] nurseBoxes;
        List<StaffModel> staff;
        List<StaffModel> doctors = new List<StaffModel>();
        List<StaffModel> nurses = new List<StaffModel>();
        int selectedPatientID;
        public FormAssignStaff()
        {
            InitializeComponent();

            patientController = new PatientController();
            staffController = new StaffController();
            doctorBoxes = [cbDoctor1, cbDoctor2, cbDoctor3];
            nurseBoxes = [cbNurse1, cbNurse2, cbNurse3];
            staff = staffController.GetAllStaff();

            if (GlobalVariables.admissionAction.Equals("Edit"))
            {
                selectedPatientID = GlobalVariables.selectedPatientID;
            }
            else
            {
                selectedPatientID = patientController.GetNextPatientID();
            }

            LoadTextboxes();
        }
        private void LoadTextboxes()
        {
            List<StaffModel> staffList = staffController.GetAllStaff();
            List<StaffModel> doctorList = staffList.Where(s => s.Role == "Doctor").ToList();
            List<StaffModel> nurseList = staffList.Where(s => s.Role == "Nurse").ToList();

            foreach (ComboBox cb in doctorBoxes)
            {
                cb.Items.Clear();
                cb.Items.Add(string.Empty);
                foreach (StaffModel doctor in doctorList)
                {
                    cb.Items.Add($"{doctor.FirstName} {doctor.LastName}");
                }
            }

            foreach (ComboBox cb in nurseBoxes)
            {
                cb.Items.Clear();
                cb.Items.Add(string.Empty);
                foreach (StaffModel nurse in nurseList)
                {
                    cb.Items.Add($"{nurse.FirstName} {nurse.LastName}");
                }
            }

            List<StaffModel> assignedStaff = GlobalVariables.assignedStaff;
            if (GlobalVariables.admissionAction.Equals("Edit"))
            {
                GlobalVariables.assignedStaff.Clear();
                List<int> assignedStaffIDs = staffController.GetAssignedStaff(selectedPatientID);
                foreach (int id in assignedStaffIDs)
                {
                    assignedStaff.Add(staffController.GetStaffByID(id));
                }
            }

            List<StaffModel> assignedDoctors = assignedStaff.Where(s => s.Role == "Doctor").ToList();
            List<StaffModel> assignedNurses = assignedStaff.Where(s => s.Role == "Nurse").ToList();

            for (int i = 0; i < assignedDoctors.Count; i++)
            {
                StaffModel doctor = assignedDoctors[i];
                ComboBox cb = doctorBoxes[i];
                cb.SelectedIndex = cb.Items.IndexOf($"{doctor.FirstName} {doctor.LastName}");
            }

            for (int i = 0; i < assignedNurses.Count; i++)
            {
                StaffModel nurse = assignedNurses[i];
                ComboBox cb = nurseBoxes[i];
                cb.SelectedIndex = cb.Items.IndexOf($"{nurse.FirstName} {nurse.LastName}");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            GlobalVariables.assignedStaff.Clear();

            foreach (ComboBox cb in doctorBoxes)
            {
                if (cb.SelectedIndex > 0)
                {
                    doctors.Add(staff.First(staff => $"{staff.FirstName} {staff.LastName}" == cb.SelectedItem.ToString()));
                }
            }

            foreach (ComboBox cb in nurseBoxes)
            {
                if (cb.SelectedIndex > 0)
                {
                    nurses.Add(staff.First(staff => $"{staff.FirstName} {staff.LastName}" == cb.SelectedItem.ToString()));
                }
            }

            foreach (StaffModel doctor in doctors)
            {
                GlobalVariables.assignedStaff.Add(doctor);
            }

            foreach (StaffModel nurse in nurses)
            {
                GlobalVariables.assignedStaff.Add(nurse);
            }

            if (GlobalVariables.admissionAction.Equals("Edit"))
            {
                staffController.DeleteStaffAssignments(selectedPatientID);

                foreach (StaffModel assigned in GlobalVariables.assignedStaff)
                {
                    staffController.AssignStaff(selectedPatientID, assigned.StaffID);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void cbSelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex > 0)
            {
                foreach (ComboBox otherCb in doctorBoxes.Concat(nurseBoxes))
                {
                    if (otherCb != cb && otherCb.SelectedItem != null && otherCb.SelectedItem.ToString() == cb.SelectedItem.ToString())
                    {
                        MessageBox.Show("This staff member has already been selected. Please choose a different staff member.", "Duplicate Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cb.SelectedIndex = 0;
                        break;
                    }
                }
            }
        }

    }
}
