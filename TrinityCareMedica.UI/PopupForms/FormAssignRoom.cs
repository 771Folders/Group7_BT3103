using System.Data;
using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.AssignmentForms
{
    public partial class FormAssignRoom : Form
    {
        RoomController roomController;
        List<RoomModel> rooms;
        public FormAssignRoom()
        {
            InitializeComponent();

            roomController = new RoomController();
            rooms = roomController.GetAllRooms();

            LoadRoomTypes();
            if (GlobalVariables.selectedPatientID != 0)
            {
                LoadData();
            }
        }
        private void LoadData()
        {
            if (GlobalVariables.assignedRoom.RoomType != null)
            {
                comboBoxRoomType.SelectedItem = GlobalVariables.assignedRoom.RoomType;
                comboBoxRoomNo.SelectedItem = GlobalVariables.assignedRoom.RoomNumber;
                comboBoxBedNo.SelectedItem = GlobalVariables.assignedRoom.BedNumber;
                dateStartDate.Value = GlobalVariables.assignedRoom.StartDate;
                if (GlobalVariables.assignedRoom.EndDate != null)
                {
                    dateEndDate.Checked = true;
                    dateEndDate.Value = GlobalVariables.assignedRoom.EndDate.Value;
                }
            }
        }
        private void LoadRoomTypes()
        {
            rooms = roomController.GetAllRooms();
            foreach (RoomModel room in rooms)
            {
                if (!comboBoxRoomType.Items.Contains(room.RoomType))
                {
                    comboBoxRoomType.Items.Add(room.RoomType);
                }
            }
        }
        private void LoadRoomNumbers(string roomType)
        {
            comboBoxRoomNo.Items.Clear();
            List<RoomModel> rooms = roomController.GetAllRooms()
                .Where(r => r.RoomType == roomType)
                .ToList();
            foreach (RoomModel room in rooms)
            {
                comboBoxRoomNo.Items.Add($"Room {room.RoomNumber}");
            }
        }
        private void LoadBedNumbers(RoomModel room)
        {
            comboBoxBedNo.Items.Clear();
            for (int i = 1; i <= room.Capacity; i++)
            {
                comboBoxBedNo.Items.Add($"Bed {i}");
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            GlobalVariables.assignedRoom = new AssignedRoomModel
            {
                RoomType = comboBoxRoomType.SelectedItem.ToString(),
                RoomNumber = int.Parse(comboBoxRoomNo.SelectedItem.ToString().Replace("Room ", "")),
                BedNumber = int.Parse(comboBoxBedNo.SelectedItem.ToString().Replace("Bed ", "")),
                StartDate = dateStartDate.Value,
                EndDate = dateEndDate.Checked ? dateEndDate.Value : null
            };
            MessageBox.Show("Successfully assigned room", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxRoomNo.Enabled = true;
            comboBoxBedNo.Items.Clear();
            comboBoxBedNo.SelectedIndex = -1;
            comboBoxBedNo.Enabled = false;
            LoadRoomNumbers(comboBoxRoomType.SelectedItem.ToString());
        }
        private void comboBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBedNo.Enabled = true;
            foreach (RoomModel room in rooms)
            {
                if (room.RoomType.Equals(comboBoxRoomType.Text) && $"Room {room.RoomNumber}" == comboBoxRoomNo.SelectedItem.ToString())
                {
                    LoadBedNumbers(room);
                    break;
                }
            }
        }
    }
}
