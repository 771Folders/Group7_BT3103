namespace EventDriven.Project.UI
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideBar = new EventDriven.Project.UI.CustomControls.CustomPanel();
            btnLogout = new Button();
            flowPanelSideBar = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnPatientInfo = new Button();
            btnAdmission = new Button();
            btnBilling = new Button();
            panelAppTitle = new Panel();
            labelAppTitle = new Label();
            panelMain = new Panel();
            panelSideBar.SuspendLayout();
            flowPanelSideBar.SuspendLayout();
            panelAppTitle.SuspendLayout();
            SuspendLayout();
            flowPanelSideBar.Visible = false;
            panelAppTitle.Visible = false;
            panelMain.Visible = false;
            panelSideBar.Visible = false;
            // 
            // panelSideBar
            // 
            panelSideBar.BorderColor = Color.Black;
            panelSideBar.BorderRadius = 0;
            panelSideBar.BorderThickness = 0;
            panelSideBar.ColorBottom = Color.MediumTurquoise;
            panelSideBar.ColorTop = SystemColors.Control;
            panelSideBar.Controls.Add(btnLogout);
            panelSideBar.Controls.Add(flowPanelSideBar);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Font = new Font("Microsoft JhengHei UI", 14F);
            panelSideBar.Location = new Point(0, 80);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(400, 1000);
            panelSideBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.AutoSize = true;
            btnLogout.Location = new Point(132, 923);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(16, 2, 16, 2);
            btnLogout.Size = new Size(136, 44);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // flowPanelSideBar
            // 
            flowPanelSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelSideBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPanelSideBar.BackColor = Color.Transparent;
            flowPanelSideBar.Controls.Add(btnDashboard);
            flowPanelSideBar.Controls.Add(btnPatientInfo);
            flowPanelSideBar.Controls.Add(btnAdmission);
            flowPanelSideBar.Controls.Add(btnBilling);
            flowPanelSideBar.Location = new Point(27, 30);
            flowPanelSideBar.Name = "flowPanelSideBar";
            flowPanelSideBar.Size = new Size(346, 614);
            flowPanelSideBar.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Image = Properties.Resources._1000065903;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(343, 111);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnPatientInfo
            // 
            btnPatientInfo.FlatStyle = FlatStyle.Popup;
            btnPatientInfo.Image = Properties.Resources._1000065901;
            btnPatientInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatientInfo.Location = new Point(3, 120);
            btnPatientInfo.Name = "btnPatientInfo";
            btnPatientInfo.Size = new Size(343, 111);
            btnPatientInfo.TabIndex = 1;
            btnPatientInfo.Text = "Patient Information Maintenance";
            btnPatientInfo.UseVisualStyleBackColor = true;
            btnPatientInfo.Click += btnPatientInfo_Click;
            // 
            // btnAdmission
            // 
            btnAdmission.FlatStyle = FlatStyle.Popup;
            btnAdmission.Image = Properties.Resources._1000065902;
            btnAdmission.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmission.Location = new Point(3, 237);
            btnAdmission.Name = "btnAdmission";
            btnAdmission.Size = new Size(343, 111);
            btnAdmission.TabIndex = 2;
            btnAdmission.Text = "Admission";
            btnAdmission.UseVisualStyleBackColor = true;
            btnAdmission.Click += btnAdmission_Click;
            // 
            // btnBilling
            // 
            btnBilling.FlatStyle = FlatStyle.Popup;
            btnBilling.Image = Properties.Resources._1000065900;
            btnBilling.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilling.Location = new Point(3, 354);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(343, 111);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "Treatment/Billing Breakdown";
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // panelAppTitle
            // 
            panelAppTitle.Controls.Add(labelAppTitle);
            panelAppTitle.Dock = DockStyle.Top;
            panelAppTitle.Location = new Point(0, 0);
            panelAppTitle.Name = "panelAppTitle";
            panelAppTitle.Size = new Size(1920, 80);
            panelAppTitle.TabIndex = 1;
            // 
            // labelAppTitle
            // 
            labelAppTitle.Dock = DockStyle.Fill;
            labelAppTitle.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAppTitle.Location = new Point(0, 0);
            labelAppTitle.Name = "labelAppTitle";
            labelAppTitle.Size = new Size(1920, 80);
            labelAppTitle.TabIndex = 0;
            labelAppTitle.Text = "TrinityCare Medica";
            labelAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(400, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1520, 1000);
            panelMain.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelMain);
            Controls.Add(panelSideBar);
            Controls.Add(panelAppTitle);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            WindowState = FormWindowState.Maximized;
            panelSideBar.ResumeLayout(false);
            panelSideBar.PerformLayout();
            flowPanelSideBar.ResumeLayout(false);
            panelAppTitle.ResumeLayout(false);
            ResumeLayout(false);
            flowPanelSideBar.Visible = true;
            panelSideBar.Visible = true;
            panelAppTitle.Visible = true;
            panelMain.Visible = true;
        }

        #endregion

        private CustomControls.CustomPanel panelSideBar;
        private Panel panelAppTitle;
        private Label labelAppTitle;
        private Panel panelMain;
        private FlowLayoutPanel flowPanelSideBar;
        private Button btnLogout;
        private Button btnDashboard;
        private Button btnPatientInfo;
        private Button btnAdmission;
        private Button btnBilling;
    }
}