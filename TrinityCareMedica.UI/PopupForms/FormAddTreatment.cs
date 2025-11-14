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

namespace TrinityCareMedica.UI.AssignmentForms
{
    public partial class FormAddTreatment : Form
    {
        MedicalRecordController medicalRecordController;
        public FormAddTreatment()
        {
            InitializeComponent();
            medicalRecordController = new MedicalRecordController();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.treatment = new TreatmentModel()
            {
                RecordID = medicalRecordController.GetNextMedicalRecordID(),
                TreatmentType = txtTreatment.Text,
                Price = Convert.ToDecimal(txtPrice.Text)
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
