using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Admin":
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    break;
                case "Doctor":
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                    break;
                case "Nurse":
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = true;
                    button4.Visible = false;
                    break;
                case "Cashier":
                    button1.Visible = true;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = true;
                    break;
                case "Receptionist":
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                    break;
            }
        }
    }
}
