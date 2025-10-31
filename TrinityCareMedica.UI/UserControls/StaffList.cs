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
    public partial class StaffList : UserControl
    {
        StaffController staffController;
        public StaffList()
        {
            staffController = new StaffController();
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dataStaff.DataSource = staffController.GetAllStaff();

            dataStaff.Columns["StaffID"].HeaderText = "Staff ID";
            dataStaff.Columns["FirstName"].HeaderText = "First Name";
            dataStaff.Columns["LastName"].HeaderText = "Last Name";

            dataStaff.Columns["StaffID"].FillWeight = 5;
            dataStaff.Columns["FirstName"].FillWeight = 20;
            dataStaff.Columns["LastName"].FillWeight = 20;
            dataStaff.Columns["Department"].FillWeight = 30;
            dataStaff.Columns["Role"].FillWeight = 10;
        }
    }
}
