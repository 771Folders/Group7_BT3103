namespace TrinityCareMedica.UI.UserControls
{
    partial class PatientRecord
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
            panel1 = new Panel();
            labelTitle = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelPatientID = new Label();
            labelFullName = new Label();
            labelDateOfBirth = new Label();
            labelAge = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelAddress = new Label();
            labelEmergencyContact = new Label();
            panelRoomAndStaff = new Panel();
            txtNurses = new TextBox();
            panelRoom = new FlowLayoutPanel();
            labelRoom = new Label();
            labelBedNo = new Label();
            panel4 = new Panel();
            labelEndDate = new Label();
            labelStartDate = new Label();
            txtDoctors = new TextBox();
            label16 = new Label();
            label17 = new Label();
            panelDischarged = new Panel();
            lblDischarged = new Label();
            panel3 = new Panel();
            btnAddMedicalRecord = new Button();
            flowMedicalRecords = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelRoomAndStaff.SuspendLayout();
            panelRoom.SuspendLayout();
            panel4.SuspendLayout();
            panelDischarged.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelTitle);
            panel1.Font = new Font("Microsoft JhengHei UI", 14F);
            panel1.Location = new Point(60, 50);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 60);
            panel1.TabIndex = 98;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 22F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(13, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(274, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Patient Record";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panelRoomAndStaff);
            panel2.Controls.Add(panelDischarged);
            panel2.Location = new Point(60, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 830);
            panel2.TabIndex = 99;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(labelPatientID);
            flowLayoutPanel1.Controls.Add(labelFullName);
            flowLayoutPanel1.Controls.Add(labelDateOfBirth);
            flowLayoutPanel1.Controls.Add(labelAge);
            flowLayoutPanel1.Controls.Add(labelGender);
            flowLayoutPanel1.Controls.Add(labelPhone);
            flowLayoutPanel1.Controls.Add(labelEmail);
            flowLayoutPanel1.Controls.Add(labelAddress);
            flowLayoutPanel1.Controls.Add(labelEmergencyContact);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(13, 13);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(669, 400);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // labelPatientID
            // 
            labelPatientID.AutoSize = true;
            labelPatientID.Location = new Point(3, 0);
            labelPatientID.Name = "labelPatientID";
            labelPatientID.Size = new Size(149, 36);
            labelPatientID.TabIndex = 0;
            labelPatientID.Text = "Patient ID:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(3, 36);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(154, 36);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(3, 72);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(185, 36);
            labelDateOfBirth.TabIndex = 2;
            labelDateOfBirth.Text = "Date of Birth:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(3, 108);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(74, 36);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(3, 144);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(119, 36);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(3, 180);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(106, 36);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 216);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(91, 36);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(3, 252);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(128, 36);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address:";
            // 
            // labelEmergencyContact
            // 
            labelEmergencyContact.AutoSize = true;
            labelEmergencyContact.Location = new Point(3, 288);
            labelEmergencyContact.Name = "labelEmergencyContact";
            labelEmergencyContact.Size = new Size(278, 36);
            labelEmergencyContact.TabIndex = 8;
            labelEmergencyContact.Text = "Emergency Contact:";
            // 
            // panelRoomAndStaff
            // 
            panelRoomAndStaff.BorderStyle = BorderStyle.FixedSingle;
            panelRoomAndStaff.Controls.Add(txtNurses);
            panelRoomAndStaff.Controls.Add(panelRoom);
            panelRoomAndStaff.Controls.Add(txtDoctors);
            panelRoomAndStaff.Controls.Add(label16);
            panelRoomAndStaff.Controls.Add(label17);
            panelRoomAndStaff.Location = new Point(13, 459);
            panelRoomAndStaff.Name = "panelRoomAndStaff";
            panelRoomAndStaff.Size = new Size(669, 358);
            panelRoomAndStaff.TabIndex = 2;
            // 
            // txtNurses
            // 
            txtNurses.Location = new Point(349, 156);
            txtNurses.Multiline = true;
            txtNurses.Name = "txtNurses";
            txtNurses.ReadOnly = true;
            txtNurses.Size = new Size(320, 202);
            txtNurses.TabIndex = 7;
            // 
            // panelRoom
            // 
            panelRoom.Controls.Add(labelRoom);
            panelRoom.Controls.Add(labelBedNo);
            panelRoom.Controls.Add(panel4);
            panelRoom.FlowDirection = FlowDirection.TopDown;
            panelRoom.Location = new Point(0, 0);
            panelRoom.Name = "panelRoom";
            panelRoom.Size = new Size(669, 114);
            panelRoom.TabIndex = 1;
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(3, 0);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(207, 36);
            labelRoom.TabIndex = 4;
            labelRoom.Text = "Current Room:";
            // 
            // labelBedNo
            // 
            labelBedNo.AutoSize = true;
            labelBedNo.Location = new Point(3, 36);
            labelBedNo.Name = "labelBedNo";
            labelBedNo.Size = new Size(189, 36);
            labelBedNo.TabIndex = 5;
            labelBedNo.Text = "Bed Number:";
            // 
            // panel4
            // 
            panel4.Controls.Add(labelEndDate);
            panel4.Controls.Add(labelStartDate);
            panel4.Location = new Point(3, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(666, 36);
            panel4.TabIndex = 6;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(346, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(140, 36);
            labelEndDate.TabIndex = 5;
            labelEndDate.Text = "End Date:";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(0, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(151, 36);
            labelStartDate.TabIndex = 4;
            labelStartDate.Text = "Start Date:";
            // 
            // txtDoctors
            // 
            txtDoctors.Location = new Point(6, 156);
            txtDoctors.Multiline = true;
            txtDoctors.Name = "txtDoctors";
            txtDoctors.ReadOnly = true;
            txtDoctors.Size = new Size(320, 202);
            txtDoctors.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 117);
            label16.Name = "label16";
            label16.Size = new Size(125, 36);
            label16.TabIndex = 4;
            label16.Text = "Doctors:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(349, 117);
            label17.Name = "label17";
            label17.Size = new Size(113, 36);
            label17.TabIndex = 5;
            label17.Text = "Nurses:";
            // 
            // panelDischarged
            // 
            panelDischarged.BorderStyle = BorderStyle.FixedSingle;
            panelDischarged.Controls.Add(lblDischarged);
            panelDischarged.Location = new Point(11, 459);
            panelDischarged.Name = "panelDischarged";
            panelDischarged.Size = new Size(671, 358);
            panelDischarged.TabIndex = 1;
            panelDischarged.Visible = false;
            // 
            // lblDischarged
            // 
            lblDischarged.AutoSize = true;
            lblDischarged.Location = new Point(190, 161);
            lblDischarged.Name = "lblDischarged";
            lblDischarged.Size = new Size(290, 36);
            lblDischarged.TabIndex = 0;
            lblDischarged.Text = "Patient is Discharged";
            lblDischarged.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(btnAddMedicalRecord);
            panel3.Location = new Point(765, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 830);
            panel3.TabIndex = 100;
            // 
            // btnAddMedicalRecord
            // 
            btnAddMedicalRecord.Location = new Point(375, 775);
            btnAddMedicalRecord.Name = "btnAddMedicalRecord";
            btnAddMedicalRecord.Size = new Size(308, 42);
            btnAddMedicalRecord.TabIndex = 0;
            btnAddMedicalRecord.Text = "Add Medical Record";
            btnAddMedicalRecord.UseVisualStyleBackColor = true;
            btnAddMedicalRecord.Click += btnAddMedicalRecord_Click;
            // 
            // flowMedicalRecords
            // 
            flowMedicalRecords.AutoScroll = true;
            flowMedicalRecords.BackColor = SystemColors.Control;
            flowMedicalRecords.FlowDirection = FlowDirection.TopDown;
            flowMedicalRecords.Location = new Point(765, 117);
            flowMedicalRecords.Name = "flowMedicalRecords";
            flowMedicalRecords.Size = new Size(695, 741);
            flowMedicalRecords.TabIndex = 0;
            flowMedicalRecords.WrapContents = false;
            // 
            // PatientRecord
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(flowMedicalRecords);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 16.2F);
            Margin = new Padding(5);
            Name = "PatientRecord";
            Size = new Size(1520, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelRoomAndStaff.ResumeLayout(false);
            panelRoomAndStaff.PerformLayout();
            panelRoom.ResumeLayout(false);
            panelRoom.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelDischarged.ResumeLayout(false);
            panelDischarged.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label labelPatientID;
        private Label labelFullName;
        private Label labelDateOfBirth;
        private Label labelAge;
        private Label labelGender;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelAddress;
        private Label labelEmergencyContact;
        private FlowLayoutPanel panelRoom;
        private Label labelRoom;
        private Label labelBedNo;
        private Panel panel4;
        private Label labelStartDate;
        private TextBox txtNurses;
        private TextBox txtDoctors;
        private Label label17;
        private Label label16;
        private Label labelEndDate;
        private Panel panelDischarged;
        private Label lblDischarged;
        private Panel panelRoomAndStaff;
        private FlowLayoutPanel flowMedicalRecords;
        private Button btnAddMedicalRecord;
    }
}
