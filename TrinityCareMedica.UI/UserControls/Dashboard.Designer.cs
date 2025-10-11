namespace TrinityCareMedica.UI.UserControls
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelRooms = new TrinityCareMedica.UI.CustomControls.CustomPanel();
            lblRoomCount = new Label();
            label8 = new Label();
            pictureRooms = new PictureBox();
            panelPatients = new TrinityCareMedica.UI.CustomControls.CustomPanel();
            lblPatientCount = new Label();
            label6 = new Label();
            picturePatients = new PictureBox();
            panelNurses = new TrinityCareMedica.UI.CustomControls.CustomPanel();
            lblNursesCount = new Label();
            label4 = new Label();
            pictureNurses = new PictureBox();
            panelDoctors = new TrinityCareMedica.UI.CustomControls.CustomPanel();
            lblDoctorCount = new Label();
            label1 = new Label();
            pictureDoctors = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRooms).BeginInit();
            panelPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePatients).BeginInit();
            panelNurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureNurses).BeginInit();
            panelDoctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureDoctors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelRooms, 1, 1);
            tableLayoutPanel1.Controls.Add(panelPatients, 0, 1);
            tableLayoutPanel1.Controls.Add(panelNurses, 1, 0);
            tableLayoutPanel1.Controls.Add(panelDoctors, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1520, 1000);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelRooms
            // 
            panelRooms.Anchor = AnchorStyles.None;
            panelRooms.BorderColor = Color.Black;
            panelRooms.BorderRadius = 20;
            panelRooms.BorderThickness = 0;
            panelRooms.ColorBottom = Color.White;
            panelRooms.ColorTop = Color.White;
            panelRooms.Controls.Add(lblRoomCount);
            panelRooms.Controls.Add(label8);
            panelRooms.Controls.Add(pictureRooms);
            panelRooms.Cursor = Cursors.Hand;
            panelRooms.Location = new Point(965, 575);
            panelRooms.Name = "panelRooms";
            panelRooms.Size = new Size(350, 350);
            panelRooms.TabIndex = 7;
            panelRooms.Click += panelRooms_Click;
            // 
            // lblRoomCount
            // 
            lblRoomCount.BackColor = Color.Transparent;
            lblRoomCount.Cursor = Cursors.Hand;
            lblRoomCount.Dock = DockStyle.Bottom;
            lblRoomCount.Font = new Font("Microsoft JhengHei UI", 18F);
            lblRoomCount.Location = new Point(0, 264);
            lblRoomCount.Name = "lblRoomCount";
            lblRoomCount.Size = new Size(350, 86);
            lblRoomCount.TabIndex = 5;
            lblRoomCount.Text = "20 Available";
            lblRoomCount.TextAlign = ContentAlignment.MiddleCenter;
            lblRoomCount.Click += panelRooms_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Cursor = Cursors.Hand;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft JhengHei UI", 18F);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(350, 86);
            label8.TabIndex = 4;
            label8.Text = "Rooms";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += panelRooms_Click;
            // 
            // pictureRooms
            // 
            pictureRooms.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureRooms.Cursor = Cursors.Hand;
            pictureRooms.Image = (Image)resources.GetObject("pictureRooms.Image");
            pictureRooms.Location = new Point(24, 21);
            pictureRooms.Name = "pictureRooms";
            pictureRooms.Size = new Size(300, 300);
            pictureRooms.SizeMode = PictureBoxSizeMode.Zoom;
            pictureRooms.TabIndex = 3;
            pictureRooms.TabStop = false;
            pictureRooms.Click += panelRooms_Click;
            // 
            // panelPatients
            // 
            panelPatients.Anchor = AnchorStyles.None;
            panelPatients.BorderColor = Color.Black;
            panelPatients.BorderRadius = 20;
            panelPatients.BorderThickness = 0;
            panelPatients.ColorBottom = Color.White;
            panelPatients.ColorTop = Color.White;
            panelPatients.Controls.Add(lblPatientCount);
            panelPatients.Controls.Add(label6);
            panelPatients.Controls.Add(picturePatients);
            panelPatients.Cursor = Cursors.Hand;
            panelPatients.Location = new Point(205, 575);
            panelPatients.Name = "panelPatients";
            panelPatients.Size = new Size(350, 350);
            panelPatients.TabIndex = 7;
            panelPatients.Click += panelPatients_Click;
            // 
            // lblPatientCount
            // 
            lblPatientCount.BackColor = Color.Transparent;
            lblPatientCount.Dock = DockStyle.Bottom;
            lblPatientCount.Font = new Font("Microsoft JhengHei UI", 18F);
            lblPatientCount.Location = new Point(0, 264);
            lblPatientCount.Name = "lblPatientCount";
            lblPatientCount.Size = new Size(350, 86);
            lblPatientCount.TabIndex = 5;
            lblPatientCount.Text = "50 Admitted";
            lblPatientCount.TextAlign = ContentAlignment.MiddleCenter;
            lblPatientCount.Click += panelPatients_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Microsoft JhengHei UI", 18F);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(350, 86);
            label6.TabIndex = 4;
            label6.Text = "Patients";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += panelPatients_Click;
            // 
            // picturePatients
            // 
            picturePatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picturePatients.Cursor = Cursors.Hand;
            picturePatients.Image = (Image)resources.GetObject("picturePatients.Image");
            picturePatients.Location = new Point(24, 21);
            picturePatients.Name = "picturePatients";
            picturePatients.Size = new Size(300, 300);
            picturePatients.SizeMode = PictureBoxSizeMode.Zoom;
            picturePatients.TabIndex = 3;
            picturePatients.TabStop = false;
            picturePatients.Click += panelPatients_Click;
            // 
            // panelNurses
            // 
            panelNurses.Anchor = AnchorStyles.None;
            panelNurses.BorderColor = Color.Black;
            panelNurses.BorderRadius = 20;
            panelNurses.BorderThickness = 0;
            panelNurses.ColorBottom = Color.White;
            panelNurses.ColorTop = Color.White;
            panelNurses.Controls.Add(lblNursesCount);
            panelNurses.Controls.Add(label4);
            panelNurses.Controls.Add(pictureNurses);
            panelNurses.Cursor = Cursors.Hand;
            panelNurses.Location = new Point(965, 75);
            panelNurses.Name = "panelNurses";
            panelNurses.Size = new Size(350, 350);
            panelNurses.TabIndex = 6;
            panelNurses.Click += panelStaff_Click;
            // 
            // lblNursesCount
            // 
            lblNursesCount.BackColor = Color.Transparent;
            lblNursesCount.Cursor = Cursors.Hand;
            lblNursesCount.Dock = DockStyle.Bottom;
            lblNursesCount.Font = new Font("Microsoft JhengHei UI", 18F);
            lblNursesCount.Location = new Point(0, 264);
            lblNursesCount.Name = "lblNursesCount";
            lblNursesCount.Size = new Size(350, 86);
            lblNursesCount.TabIndex = 5;
            lblNursesCount.Text = "8 Available";
            lblNursesCount.TextAlign = ContentAlignment.MiddleCenter;
            lblNursesCount.Click += panelStaff_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft JhengHei UI", 18F);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(350, 86);
            label4.TabIndex = 4;
            label4.Text = "Nurses";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += panelStaff_Click;
            // 
            // pictureNurses
            // 
            pictureNurses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureNurses.Cursor = Cursors.Hand;
            pictureNurses.Image = (Image)resources.GetObject("pictureNurses.Image");
            pictureNurses.Location = new Point(24, 21);
            pictureNurses.Name = "pictureNurses";
            pictureNurses.Size = new Size(300, 300);
            pictureNurses.SizeMode = PictureBoxSizeMode.Zoom;
            pictureNurses.TabIndex = 3;
            pictureNurses.TabStop = false;
            pictureNurses.Click += panelStaff_Click;
            // 
            // panelDoctors
            // 
            panelDoctors.Anchor = AnchorStyles.None;
            panelDoctors.BorderColor = Color.Black;
            panelDoctors.BorderRadius = 20;
            panelDoctors.BorderThickness = 0;
            panelDoctors.ColorBottom = Color.White;
            panelDoctors.ColorTop = Color.White;
            panelDoctors.Controls.Add(lblDoctorCount);
            panelDoctors.Controls.Add(label1);
            panelDoctors.Controls.Add(pictureDoctors);
            panelDoctors.Cursor = Cursors.Hand;
            panelDoctors.Location = new Point(205, 75);
            panelDoctors.Name = "panelDoctors";
            panelDoctors.Size = new Size(350, 350);
            panelDoctors.TabIndex = 0;
            panelDoctors.Click += panelStaff_Click;
            // 
            // lblDoctorCount
            // 
            lblDoctorCount.BackColor = Color.Transparent;
            lblDoctorCount.Cursor = Cursors.Hand;
            lblDoctorCount.Dock = DockStyle.Bottom;
            lblDoctorCount.Font = new Font("Microsoft JhengHei UI", 18F);
            lblDoctorCount.Location = new Point(0, 264);
            lblDoctorCount.Name = "lblDoctorCount";
            lblDoctorCount.Size = new Size(350, 86);
            lblDoctorCount.TabIndex = 5;
            lblDoctorCount.Text = "8 Available";
            lblDoctorCount.TextAlign = ContentAlignment.MiddleCenter;
            lblDoctorCount.Click += panelStaff_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft JhengHei UI", 18F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 86);
            label1.TabIndex = 4;
            label1.Text = "Doctors";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += panelStaff_Click;
            // 
            // pictureDoctors
            // 
            pictureDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureDoctors.Cursor = Cursors.Hand;
            pictureDoctors.Image = (Image)resources.GetObject("pictureDoctors.Image");
            pictureDoctors.Location = new Point(24, 21);
            pictureDoctors.Name = "pictureDoctors";
            pictureDoctors.Size = new Size(300, 300);
            pictureDoctors.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDoctors.TabIndex = 3;
            pictureDoctors.TabStop = false;
            pictureDoctors.Click += panelStaff_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(tableLayoutPanel1);
            Name = "Dashboard";
            Size = new Size(1520, 1000);
            Load += Dashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelRooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureRooms).EndInit();
            panelPatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePatients).EndInit();
            panelNurses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureNurses).EndInit();
            panelDoctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureDoctors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.CustomPanel panelDoctors;
        private Label label1;
        private PictureBox pictureDoctors;
        private CustomControls.CustomPanel panelRooms;
        private Label lblRoomCount;
        private Label label8;
        private PictureBox pictureRooms;
        private CustomControls.CustomPanel panelPatients;
        private Label lblPatientCount;
        private Label label6;
        private PictureBox picturePatients;
        private CustomControls.CustomPanel panelNurses;
        private Label lblNursesCount;
        private Label label4;
        private PictureBox pictureNurses;
        private Label lblDoctorCount;
    }
}
