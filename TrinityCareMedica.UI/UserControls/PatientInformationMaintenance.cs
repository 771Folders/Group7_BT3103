using TrinityCareMedica.Businesslogic.Controller;
using TrinityCareMedica.Model;

namespace TrinityCareMedica.UI.UserControls
{
    public partial class PatientInformationMaintenance : UserControl
    {
        #region Local Variables
        PatientController patientController;
        public event EventHandler GoToDashboard;
        public event EventHandler GoToAddPatient;
        public event EventHandler GoToEditPatient;
        public event EventHandler GoToPatientRecord;
        public event EventHandler GoToBilling;
        public event EventHandler GoToDischarge;
        private bool isMultiSelectMode = false;
        private List<string> selectedIds = new List<string>();
        #endregion
        public PatientInformationMaintenance()
        {
            patientController = new PatientController();
            InitializeComponent();
            DoubleBuffering();
            CheckLoggedUser();
            LoadData();
        }
        private void DoubleBuffering()
        {
            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                dataPatients,
                new object[] { true });
        }
        private void CheckLoggedUser()
        {
            switch (FormLogin.LoggedUser.Role)
            {
                case "Doctor":
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnBilling.Visible = false;
                    btnDischarge.Visible = false;
                    break;
                case "Nurse":
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnBilling.Visible = false;
                    btnDischarge.Visible = false;
                    break;
                case "Receptionist":
                    dataPatients.CellDoubleClick -= dataPatients_CellDoubleClick;
                    btnBilling.Visible = false;
                    btnDischarge.Visible = false;
                    btnView.Visible = false;
                    break;
                case "Cashier":
                    dataPatients.CellDoubleClick -= dataPatients_CellDoubleClick;
                    btnAdd.Visible = false;
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                    btnView.Visible = false;
                    break;
            }
        }
        private void LoadData()
        {
            if (!isMultiSelectMode)
            {
                dataPatients.DataSource = patientController.GetAllPatients();
                foreach (DataGridViewColumn column in dataPatients.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataPatients.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["SelectColumn"].Value);
                    if (isChecked)
                    {
                        selectedIds.Add(row.Cells["PatientID"].Value.ToString());
                    }
                }

                dataPatients.DataSource = patientController.GetAllPatients();

                foreach (DataGridViewRow row in dataPatients.Rows)
                {
                    if (selectedIds.Contains(row.Cells["PatientID"].Value.ToString()))
                    {
                        row.Cells["SelectColumn"].Value = true;
                    }
                }
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
        }
        private void dataPatients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnView.PerformClick();
        }
        private void dataPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            DataGridViewRow row = dataPatients.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells["SelectColumn"];
            if (cell == null) return;

            bool currentlyChecked = false;
            if (cell.Value != null && cell.Value != DBNull.Value)
                currentlyChecked = Convert.ToBoolean(cell.Value);

            cell.Value = !currentlyChecked;
            row.Selected = !currentlyChecked;
        }
        private void dataPatients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = dataPatients.Columns[e.ColumnIndex].DataPropertyName;
            bool ascending = true;

            if (dataPatients.Tag is Tuple<string, bool> lastSort &&
                lastSort.Item1 == columnName)
            {
                ascending = !lastSort.Item2;
            }

            var dataSource = (List<PatientModel>)dataPatients.DataSource;

            if (isMultiSelectMode)
            {
                foreach (DataGridViewRow row in dataPatients.Rows)
                {
                    bool isChecked = Convert.ToBoolean(row.Cells["SelectColumn"].Value);
                    if (isChecked)
                    {
                        selectedIds.Add(row.Cells["PatientID"].Value.ToString());
                    }
                }

                if (ascending)
                    dataPatients.DataSource = dataSource.OrderBy(p => GetPropertyValue(p, columnName)).ToList();
                else
                    dataPatients.DataSource = dataSource.OrderByDescending(p => GetPropertyValue(p, columnName)).ToList();

                foreach (DataGridViewRow row in dataPatients.Rows)
                {
                    if (selectedIds.Contains(row.Cells["PatientID"].Value.ToString()))
                    {
                        row.Cells["SelectColumn"].Value = true;
                    }
                }
            }
            else
            {
                if (ascending)
                    dataPatients.DataSource = dataSource.OrderBy(p => GetPropertyValue(p, columnName)).ToList();
                else
                    dataPatients.DataSource = dataSource.OrderByDescending(p => GetPropertyValue(p, columnName)).ToList();
            }

            dataPatients.Tag = Tuple.Create(columnName, ascending);
        }
        private object GetPropertyValue(PatientModel patient, string propertyName)
        {
            return typeof(PatientModel).GetProperty(propertyName).GetValue(patient);
        }
        #region Button Click Events
        private void btnToggleSelect_Click(object sender, EventArgs e)
        {
            if (!isMultiSelectMode)
            {
                isMultiSelectMode = true;
                dataPatients.MultiSelect = true;
                dataPatients.DefaultCellStyle.SelectionBackColor = dataPatients.DefaultCellStyle.BackColor;
                dataPatients.DefaultCellStyle.SelectionForeColor = dataPatients.DefaultCellStyle.ForeColor;
                dataPatients.CellDoubleClick -= dataPatients_CellDoubleClick;
                dataPatients.CellClick += dataPatients_CellClick;
                selectedIds.Clear();
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnView.Enabled = false;
                btnBilling.Enabled = false;
                btnDischarge.Enabled = false;

                if (dataPatients.Columns["SelectColumn"] == null)
                {
                    DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn()
                    {
                        Name = "SelectColumn",
                        HeaderText = "",
                        Width = 30,
                        ValueType = typeof(bool),
                        TrueValue = true,
                        FalseValue = false
                    };
                    dataPatients.Columns.Insert(0, chk);
                }

                btnToggleSelect.Text = "Select: On";
            }
            else
            {
                isMultiSelectMode = false;
                dataPatients.MultiSelect = false;
                dataPatients.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
                dataPatients.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
                dataPatients.CellDoubleClick += dataPatients_CellDoubleClick;
                dataPatients.CellClick -= dataPatients_CellClick;
                selectedIds.Clear();
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnView.Enabled = true;
                btnBilling.Enabled = true;
                btnDischarge.Enabled = true;

                if (dataPatients.Columns["SelectColumn"] != null)
                {
                    dataPatients.Columns.Remove("SelectColumn");
                }

                btnToggleSelect.Text = "Select: Off";
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isMultiSelectMode)
                {
                    string searchTerm = txtSearch.Text.Trim();
                    dataPatients.DataSource = patientController.SearchPatients(searchTerm);
                }
                else
                {
                    foreach (DataGridViewRow row in dataPatients.Rows)
                    {
                        bool isChecked = Convert.ToBoolean(row.Cells["SelectColumn"].Value);
                        if (isChecked)
                        {
                            selectedIds.Add(row.Cells["PatientID"].Value.ToString());
                        }
                    }

                    string searchTerm = txtSearch.Text.Trim();
                    dataPatients.DataSource = patientController.SearchPatients(searchTerm);

                    foreach (DataGridViewRow row in dataPatients.Rows)
                    {
                        if (selectedIds.Contains(row.Cells["PatientID"].Value.ToString()))
                        {
                            row.Cells["SelectColumn"].Value = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoToAddPatient?.Invoke(this, EventArgs.Empty);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataPatients.CurrentRow != null)
                {
                    int selected = Convert.ToInt32(dataPatients.CurrentRow.Cells["PatientID"].Value);
                    FormMain.selectedPatientID = selected;
                }
                GoToEditPatient?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during edit: " + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isMultiSelectMode)
                {
                    if (dataPatients.SelectedRows.Count > 0)
                    {
                        int patientId = Convert.ToInt32(dataPatients.SelectedRows[0].Cells["PatientID"].Value);
                        DialogResult confirmResult = MessageBox.Show("Are you sure to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirmResult == DialogResult.Yes)
                        {
                            patientController.DeletePatient(patientId);
                            txtSearch.Clear();
                            LoadData();
                            MessageBox.Show("Patient deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Deletion cancelled.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a patient to delete.");
                    }
                }
                else
                {
                    List<int> selectedPatientIds = new List<int>();
                    foreach (DataGridViewRow row in dataPatients.Rows)
                    {
                        if (row.Cells["SelectColumn"].Value != null && (bool)row.Cells["SelectColumn"].Value == true)
                        {
                            selectedPatientIds.Add(Convert.ToInt32(row.Cells["PatientID"].Value));
                        }
                    }
                    if (selectedPatientIds.Count > 0)
                    {
                        DialogResult confirmResult = MessageBox.Show($"Are you sure to delete {selectedPatientIds.Count} selected patients?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirmResult == DialogResult.Yes)
                        {
                            foreach (var id in selectedPatientIds)
                            {
                                patientController.DeletePatient(id);
                            }
                            txtSearch.Clear();
                            LoadData();
                            MessageBox.Show("Selected patients deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Deletion cancelled.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select patients to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deletion: " + ex.Message);
            }
        }
        private void btnBilling_Click(object sender, EventArgs e)
        {
            GoToBilling?.Invoke(this, EventArgs.Empty);
        }
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            GoToDischarge?.Invoke(this, EventArgs.Empty);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataPatients.CurrentCell.RowIndex < 0) return;
                if (dataPatients.CurrentRow == null)
                {
                    MessageBox.Show("Please select a patient.");
                }

                int selected = Convert.ToInt32(dataPatients.CurrentRow.Cells["PatientID"].Value);
                FormMain.selectedPatientID = selected;
                GoToPatientRecord?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}