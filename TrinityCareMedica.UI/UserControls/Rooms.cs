using TrinityCareMedica.Businesslogic.Controller;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class Rooms : UserControl
    {
        RoomController roomController;
        public Rooms()
        {
            roomController = new RoomController();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataRooms.DataSource = roomController.GetAllRooms();
        }
    }
}
