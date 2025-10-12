using TrinityCareMedica.Businesslogic.Controller;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class StaffList : UserControl
    {
        StaffController staffController;
        public StaffList()
        {
            staffController = new StaffController();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataStaff.DataSource = staffController.GetAllStaff();
            dataStaff.Columns["StaffID"].FillWeight = 5;
            dataStaff.Columns["FirstName"].FillWeight = 20;
            dataStaff.Columns["LastName"].FillWeight = 20;
            dataStaff.Columns["Role"].FillWeight = 15;
            dataStaff.Columns["Department"].FillWeight = 45;
            dataStaff.Columns["PhoneNumber"].FillWeight = 23;
            dataStaff.Columns["Email"].FillWeight = 42;
            dataStaff.Columns["DateHired"].FillWeight = 20;
        }
    }
}
