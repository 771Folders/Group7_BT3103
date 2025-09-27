using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class FormPatientInformationMaintenance : Form
    {
        PatientController patientController;
        public FormPatientInformationMaintenance()
        {
            InitializeComponent();
            patientController = new PatientController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            FormAdmission formAdmission = new FormAdmission();
            formAdmission.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void FormPatientInformationMaintenance_Load(object sender, EventArgs e)
        {
            List<PatientModel> patients = patientController.GetAllPatients();
            foreach (var patient in patients)
            {
                Debug.WriteLine($"{patient.PatientID}: {patient.FirstName} {patient.LastName}");
            }
            dataGridView1.DataSource = patients;
        }
    }
}
