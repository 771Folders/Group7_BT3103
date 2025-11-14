namespace TrinityCareMedica.UI.UserControls
{
    partial class PatientInformationMaintenance
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataPatients = new DataGridView();
            panel1 = new Panel();
            btnToggleSelect = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnRefresh = new PictureBox();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            flowPatientInfoButtons = new FlowLayoutPanel();
            btnView = new Button();
            btnBilling = new Button();
            btnDischarge = new Button();
            ((System.ComponentModel.ISupportInitialize)dataPatients).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).BeginInit();
            flowPatientInfoButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataPatients
            // 
            dataPatients.AllowUserToAddRows = false;
            dataPatients.AllowUserToDeleteRows = false;
            dataPatients.AllowUserToResizeRows = false;
            dataPatients.Anchor = AnchorStyles.None;
            dataPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataPatients.EditMode = DataGridViewEditMode.EditOnEnter;
            dataPatients.EnableHeadersVisualStyles = false;
            dataPatients.Location = new Point(60, 116);
            dataPatients.MultiSelect = false;
            dataPatients.Name = "dataPatients";
            dataPatients.ReadOnly = true;
            dataPatients.RowHeadersVisible = false;
            dataPatients.RowHeadersWidth = 51;
            dataPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataPatients.ShowCellToolTips = false;
            dataPatients.ShowEditingIcon = false;
            dataPatients.Size = new Size(1400, 750);
            dataPatients.TabIndex = 0;
            dataPatients.CellDoubleClick += dataPatients_CellDoubleClick;
            dataPatients.ColumnHeaderMouseClick += dataPatients_ColumnHeaderMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnToggleSelect);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Microsoft JhengHei UI", 14F);
            panel1.Location = new Point(60, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 60);
            panel1.TabIndex = 1;
            // 
            // btnToggleSelect
            // 
            btnToggleSelect.Location = new Point(770, 10);
            btnToggleSelect.Name = "btnToggleSelect";
            btnToggleSelect.Size = new Size(149, 40);
            btnToggleSelect.TabIndex = 4;
            btnToggleSelect.Text = "Select: Off";
            btnToggleSelect.UseVisualStyleBackColor = true;
            btnToggleSelect.Click += btnToggleSelect_Click;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Location = new Point(1267, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(971, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(290, 37);
            txtSearch.TabIndex = 2;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.BackgroundImage = Properties.Resources.refresh;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.Location = new Point(925, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 37);
            btnRefresh.TabIndex = 1;
            btnRefresh.TabStop = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 22F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 7);
            label1.Name = "label1";
            label1.Size = new Size(594, 47);
            label1.TabIndex = 0;
            label1.Text = "Patient Information Maintenance";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft JhengHei UI", 14F);
            btnAdd.Location = new Point(7, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 60);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft JhengHei UI", 14F);
            btnDelete.Location = new Point(379, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(180, 60);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft JhengHei UI", 14F);
            btnEdit.Location = new Point(193, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(180, 60);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // flowPatientInfoButtons
            // 
            flowPatientInfoButtons.BackColor = Color.Transparent;
            flowPatientInfoButtons.Controls.Add(btnDischarge);
            flowPatientInfoButtons.Controls.Add(btnBilling);
            flowPatientInfoButtons.Controls.Add(btnView);
            flowPatientInfoButtons.Controls.Add(btnDelete);
            flowPatientInfoButtons.Controls.Add(btnEdit);
            flowPatientInfoButtons.Controls.Add(btnAdd);
            flowPatientInfoButtons.FlowDirection = FlowDirection.RightToLeft;
            flowPatientInfoButtons.Location = new Point(340, 898);
            flowPatientInfoButtons.Name = "flowPatientInfoButtons";
            flowPatientInfoButtons.Size = new Size(1120, 69);
            flowPatientInfoButtons.TabIndex = 5;
            // 
            // btnView
            // 
            btnView.Font = new Font("Microsoft JhengHei UI", 14F);
            btnView.Location = new Point(565, 3);
            btnView.Name = "btnView";
            btnView.Size = new Size(180, 60);
            btnView.TabIndex = 7;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnBilling
            // 
            btnBilling.Font = new Font("Microsoft JhengHei UI", 14F);
            btnBilling.Location = new Point(751, 3);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(180, 60);
            btnBilling.TabIndex = 6;
            btnBilling.Text = "Billing";
            btnBilling.UseVisualStyleBackColor = true;
            btnBilling.Click += btnBilling_Click;
            // 
            // btnDischarge
            // 
            btnDischarge.Font = new Font("Microsoft JhengHei UI", 14F);
            btnDischarge.Location = new Point(937, 3);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(180, 60);
            btnDischarge.TabIndex = 5;
            btnDischarge.Text = "Discharge";
            btnDischarge.UseVisualStyleBackColor = true;
            btnDischarge.Click += btnDischarge_Click;
            // 
            // PatientInformationMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(panel1);
            Controls.Add(dataPatients);
            Controls.Add(flowPatientInfoButtons);
            Name = "PatientInformationMaintenance";
            Size = new Size(1520, 1000);
            ((System.ComponentModel.ISupportInitialize)dataPatients).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRefresh).EndInit();
            flowPatientInfoButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataPatients;
        private Panel panel1;
        private Label label1;
        private PictureBox btnRefresh;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private FlowLayoutPanel flowPatientInfoButtons;
        private Button btnToggleSelect;
        private Button btnDischarge;
        private Button btnBilling;
        private Button btnView;
    }
}
