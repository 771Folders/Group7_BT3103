using System.Text.RegularExpressions;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI
{
    public partial class FormRoomAssignment : Form
    {
        #region Local Variables
        PatientController patientController;
        RoomController roomController;
        int selectedPatientID;
        PatientModel patient;
        string action;
        #endregion
        public FormRoomAssignment()
        {
            patientController = new PatientController();
            roomController = new RoomController();
            selectedPatientID = FormMain.selectedPatientID;
            patient = patientController.GetPatientByID(selectedPatientID);
            action = FormMain.assignAction;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            if (action.Equals("Old"))
            {
                labelPatientID.Text = $"Patient ID: {selectedPatientID.ToString()}";
                labelName.Text = $"Patient Name: {patient.FirstName} {patient.MiddleName} {patient.LastName}";
            }
            else
            {
                labelPatientID.Text = patientController.GetNextPatientID().ToString();
                labelName.Visible = false;
            }

            cbRoomType.Items.Add(string.Empty);
            List<string> roomTypes = roomController.GetRoomTypes();
            foreach (string roomType in roomTypes)
            {
                cbRoomType.Items.Add(roomType);
            }

            PatientRoomModel room = new PatientRoomModel();
            if (FormMain.assignAction.Equals("Old"))
            {
                room = checkAssignedRoom(selectedPatientID);
            }
            else
            {
                room = FormMain.room;
            }
            if (room.RoomType != null)
            {
                cbRoomType.Text = room.RoomType;
                int roomNum = room.RoomNumber;
                if (cbRoomNo.Items.Contains($"{roomNum} (Current)"))
                    cbRoomNo.SelectedIndex = cbRoomNo.Items.IndexOf($"{roomNum} (Current)");
                else
                    cbRoomNo.Text = roomNum.ToString();
                string bedNum = room.BedNumber;
                if (cbBedNo.Items.Contains($"{bedNum} (Current)"))
                    cbBedNo.SelectedIndex = cbBedNo.Items.IndexOf($"{bedNum} (Current)");
                else
                    cbBedNo.Text = bedNum;
                dateStartDate.Text = room.StartDate.ToShortDateString();
                if (room.EndDate.HasValue)
                {
                    dateEndDate.Checked = true;
                    dateEndDate.Format = DateTimePickerFormat.Short;
                    dateEndDate.Text = room.EndDate.ToString();
                }
                else
                {
                    dateEndDate.Checked = false;
                    dateEndDate.Format = DateTimePickerFormat.Custom;
                    dateEndDate.CustomFormat = " ";
                }
            }
            else
            {
                cbRoomNo.Text = "Select a Room";
                cbBedNo.Text = "Select a Room";
                cbRoomNo.Enabled = false;
                cbBedNo.Enabled = false;
            }

        }
        private PatientRoomModel checkAssignedRoom(int selectedPatientID)
        {
            PatientRoomModel room = new PatientRoomModel();
            return room = roomController.GetRoomByPatientID(selectedPatientID);
        }
        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoomType.SelectedIndex > 0)
            {
                EnableRoomNumbers();
                cbBedNo.Items.Clear();
                cbBedNo.Enabled = false;
                buttonAssign.Enabled = false;
            }
            else
            {
                cbRoomNo.Text = "Select a Room";
                cbRoomNo.Enabled = false;
                cbBedNo.Text = "Select a Room";
                cbBedNo.Enabled = false;
            }
        }
        private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomNo.SelectedIndexChanged -= cbRoomNo_SelectedIndexChanged;
            string selectedItem = cbRoomNo.Text;

            if (selectedItem.Contains("Full"))
            {
                cbBedNo.Text = "Select a Room";
                cbBedNo.Enabled = false;
                cbRoomNo.SelectedIndex = -1;
                MessageBox.Show("This Room is already full.", "Full Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EnableBedNumbers();
            }
            cbRoomNo.SelectedIndexChanged += cbRoomNo_SelectedIndexChanged;
        }
        private void cbBedNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbBedNo.Text;

            if (selectedItem.Contains("Occupied"))
            {
                cbBedNo.SelectedIndex = -1;
                MessageBox.Show("This Bed is already occupied.", "Bed Occupied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buttonAssign.Enabled = true;
            }
        }
        private void EnableRoomNumbers()
        {
            cbRoomNo.Items.Clear();
            cbRoomNo.Enabled = true;
            cbRoomNo.Text = string.Empty;

            List<int> roomNumbers = roomController.GetRoomNumbers(cbRoomType.Text);
            List<string>[] occupiedBeds = new List<string>[roomNumbers.Count];
            int capacity = roomController.GetRoomCapacity(cbRoomType.Text);

            for (int i = 0; i < occupiedBeds.Length; i++)
            {
                occupiedBeds[i] = roomController.GetAvailableBedNumbers(cbRoomType.Text, roomNumbers[i]);
            }

            for (int i = 0; i < roomNumbers.Count; i++)
            {
                if (capacity > occupiedBeds[i].Count)
                {
                    cbRoomNo.Items.Add(roomNumbers[i]);
                }
                else
                {
                    if (roomController.GetRoomByPatientID(selectedPatientID) != null)
                    {
                        if (roomNumbers[i].Equals(roomController.GetRoomByPatientID(selectedPatientID).RoomNumber))
                            cbRoomNo.Items.Add($"{roomNumbers[i]} (Current)");
                        else
                            cbRoomNo.Items.Add($"{roomNumbers[i]} (Full)");
                    }
                    else
                        cbRoomNo.Items.Add($"{roomNumbers[i]} (Full)");
                }
            }
        }
        private void EnableBedNumbers()
        {
            cbBedNo.Items.Clear();
            cbBedNo.Enabled = true;
            cbBedNo.Text = string.Empty;
            int capacity = roomController.GetRoomCapacity(cbRoomType.Text);
            List<string> occupiedBeds = roomController.GetAvailableBedNumbers(cbRoomType.Text, int.Parse(cbRoomNo.Text.Replace(" (Current)", string.Empty)));
            for (int i = 0; i < capacity; i++)
            {
                if (capacity > 2)
                {
                    if (!occupiedBeds.Contains((i + 1).ToString()))
                        cbBedNo.Items.Add(i + 1);
                    else
                    {
                        if(roomController.GetRoomByPatientID(selectedPatientID) != null) 
                        {
                            if (matchBed(occupiedBeds[i]))
                                cbBedNo.Items.Add($"{i + 1} (Current)");
                        }
                        else
                            cbBedNo.Items.Add($"{i + 1} (Occupied)");
                        }
                }
                else
                {
                    string bedNumber = i == 0 ? "A" : "B";
                    if (!occupiedBeds.Contains(bedNumber))
                        cbBedNo.Items.Add(bedNumber);
                    else
                    {
                        if (roomController.GetRoomByPatientID(selectedPatientID) != null) 
                        {
                            if (matchBed(bedNumber))
                                cbBedNo.Items.Add($"{bedNumber} (Current)");
                            else
                                cbBedNo.Items.Add($"{bedNumber} (Occupied)");
                        }
                        else
                            cbBedNo.Items.Add($"{bedNumber} (Occupied)");
                    }
                }
            }
        }
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            if (action.Equals("New"))
            {
                AssignToNewPatient();
            }
            else if (action.Equals("Old"))
            {
                roomController.DeleteRoomAssignment(selectedPatientID);
                AssignToOldPatient();
            }
        }
        private void AssignToNewPatient()
        {
            PatientRoomModel roomModel = new PatientRoomModel();
            try
            {
                roomModel = new PatientRoomModel
                {
                    RoomType = cbRoomType.Text,
                    RoomNumber = int.Parse(cbRoomNo.Text),
                    BedNumber = cbBedNo.Text,
                    StartDate = dateStartDate.Value.Date,
                    EndDate = dateEndDate.Checked == true ? dateEndDate.Value.Date : null
                };
                if (roomModel.BedNumber.Contains("(Current)"))
                {
                    roomModel.BedNumber.Replace(" (Current)", string.Empty);
                }
            }
            catch
            {
                MessageBox.Show("Not assigned to a room.", "Unassigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (roomModel.RoomType != null)
            {
                if (checkValidDate(dateStartDate.Value.Date, dateEndDate.Value.Date))
                {
                    FormMain.room = roomModel;
                    Close();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Date");
                }
            }
            else
            {
                FormMain.room = roomModel;
                Close();
                DialogResult = DialogResult.OK;
            }
        }
        private void AssignToOldPatient()
        {
            PatientRoomModel roomModel = new PatientRoomModel
            {
                RoomType = cbRoomType.Text,
                RoomNumber = int.Parse(cbRoomNo.Text),
                BedNumber = cbBedNo.Text,
                StartDate = dateStartDate.Value.Date,
                EndDate = dateEndDate.Checked == true ? dateEndDate.Value.Date : null
            };
            if (roomModel.BedNumber.Contains("(Current)"))
            {
                roomModel.BedNumber = roomModel.BedNumber.Replace(" (Current)", "");
            }
            if (roomModel == null)
            {
                roomController.DeleteRoomAssignment(selectedPatientID);
                MessageBox.Show("Successfully unassigned patient from room", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                DialogResult = DialogResult.OK;
            }
            if (checkValidDate(dateStartDate.Value.Date, dateEndDate.Value.Date))
            {
                roomController.AssignRoom(selectedPatientID, roomModel);
                MessageBox.Show("Succesfully Assigned Room", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Date");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }
        private void dateEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateEndDate.Checked == false)
            {
                dateEndDate.Format = DateTimePickerFormat.Custom;
                dateEndDate.CustomFormat = " ";
            }
            else
            {
                dateEndDate.Format = DateTimePickerFormat.Short;
            }
        }
        private bool checkValidDate(DateTime start, DateTime end)
        {
            if (start <= end || dateEndDate.Checked == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool matchBed(string bedNumber)
        {
            PatientRoomModel room = roomController.GetRoomByPatientID(selectedPatientID);
            if (room.BedNumber.Equals(bedNumber))
            {
                return true;
            }
            return false;
        }
    }
}