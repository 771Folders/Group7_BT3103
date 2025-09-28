using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormAdmission : Form
    {
        public FormAdmission()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            FormPatientInformationMaintenance formPatientInformationMaintenance = new FormPatientInformationMaintenance();
            formPatientInformationMaintenance.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                PatientModel patient = new PatientModel()
                {
                    FirstName = textBox4.Text,
                    LastName = textBox4.Text,
                    MiddleName = textBox3.Text,
                    Address = textBox1.Text,

                };
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
