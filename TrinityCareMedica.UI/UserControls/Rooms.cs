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
