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
            lblPatientID = new Label();
            panelPatientInfo = new Panel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblRoom = new Label();
            lblBedNo = new Label();
            panel3 = new Panel();
            lblEndDate = new Label();
            lblStartDate = new Label();
            panel4 = new Panel();
            textboxNurses = new RichTextBox();
            textboxDoctors = new RichTextBox();
            lblNurses = new Label();
            lblDoctors = new Label();
            label9 = new Label();
            flowPatientInfo = new FlowLayoutPanel();
            lblAdmissionDate = new Label();
            lblName = new Label();
            panel2 = new Panel();
            lblDateOfBirth = new Label();
            lblGender = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblEmergencyContact = new Label();
            lblEmergencyContactPhone = new Label();
            lblPatientInfo = new Label();
            panelMedRecord = new Panel();
            label15 = new Label();
            flowMedicalRecords = new FlowLayoutPanel();
            btnAddMedRecord = new Button();
            panel1.SuspendLayout();
            panelPatientInfo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            flowPatientInfo.SuspendLayout();
            panel2.SuspendLayout();
            panelMedRecord.SuspendLayout();
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
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Microsoft JhengHei UI", 14F);
            lblPatientID.ForeColor = SystemColors.ControlText;
            lblPatientID.Location = new Point(3, 0);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(130, 30);
            lblPatientID.TabIndex = 1;
            lblPatientID.Text = "Patient ID:";
            // 
            // panelPatientInfo
            // 
            panelPatientInfo.BackColor = SystemColors.Control;
            panelPatientInfo.Controls.Add(button2);
            panelPatientInfo.Controls.Add(button1);
            panelPatientInfo.Controls.Add(flowLayoutPanel1);
            panelPatientInfo.Controls.Add(label9);
            panelPatientInfo.Controls.Add(flowPatientInfo);
            panelPatientInfo.Controls.Add(lblPatientInfo);
            panelPatientInfo.Font = new Font("Microsoft JhengHei UI", 14F);
            panelPatientInfo.Location = new Point(60, 117);
            panelPatientInfo.Name = "panelPatientInfo";
            panelPatientInfo.Size = new Size(638, 847);
            panelPatientInfo.TabIndex = 99;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 14F);
            button2.Location = new Point(157, 784);
            button2.Name = "button2";
            button2.Size = new Size(201, 60);
            button2.TabIndex = 108;
            button2.Text = "Transfer Room";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 14F);
            button1.Location = new Point(364, 784);
            button1.Name = "button1";
            button1.Size = new Size(271, 60);
            button1.TabIndex = 102;
            button1.Text = "Assign Doctor/Nurse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblRoom);
            flowLayoutPanel1.Controls.Add(lblBedNo);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(13, 471);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(609, 287);
            flowLayoutPanel1.TabIndex = 107;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(3, 0);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(231, 30);
            lblRoom.TabIndex = 106;
            lblRoom.Text = "Current Room: N/A";
            // 
            // lblBedNo
            // 
            lblBedNo.AutoSize = true;
            lblBedNo.Location = new Point(3, 30);
            lblBedNo.Name = "lblBedNo";
            lblBedNo.Size = new Size(215, 30);
            lblBedNo.TabIndex = 107;
            lblBedNo.Text = "Bed Number: N/A";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblEndDate);
            panel3.Controls.Add(lblStartDate);
            panel3.Location = new Point(3, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 34);
            panel3.TabIndex = 109;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(306, 0);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(99, 30);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "To: N/A";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(0, 0);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(130, 30);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "From: N/A";
            // 
            // panel4
            // 
            panel4.Controls.Add(textboxNurses);
            panel4.Controls.Add(textboxDoctors);
            panel4.Controls.Add(lblNurses);
            panel4.Controls.Add(lblDoctors);
            panel4.Location = new Point(3, 103);
            panel4.Name = "panel4";
            panel4.Size = new Size(606, 181);
            panel4.TabIndex = 111;
            // 
            // textboxNurses
            // 
            textboxNurses.BackColor = SystemColors.Control;
            textboxNurses.BorderStyle = BorderStyle.None;
            textboxNurses.Font = new Font("Microsoft JhengHei UI", 13F);
            textboxNurses.Location = new Point(420, 3);
            textboxNurses.Name = "textboxNurses";
            textboxNurses.ReadOnly = true;
            textboxNurses.ScrollBars = RichTextBoxScrollBars.Vertical;
            textboxNurses.Size = new Size(183, 174);
            textboxNurses.TabIndex = 114;
            textboxNurses.Text = "";
            // 
            // textboxDoctors
            // 
            textboxDoctors.BackColor = SystemColors.Control;
            textboxDoctors.BorderStyle = BorderStyle.None;
            textboxDoctors.Font = new Font("Microsoft JhengHei UI", 13F);
            textboxDoctors.Location = new Point(120, 4);
            textboxDoctors.Name = "textboxDoctors";
            textboxDoctors.ReadOnly = true;
            textboxDoctors.ScrollBars = RichTextBoxScrollBars.Vertical;
            textboxDoctors.Size = new Size(183, 174);
            textboxDoctors.TabIndex = 113;
            textboxDoctors.Text = "";
            // 
            // lblNurses
            // 
            lblNurses.AutoSize = true;
            lblNurses.Location = new Point(309, 0);
            lblNurses.Name = "lblNurses";
            lblNurses.Size = new Size(108, 30);
            lblNurses.TabIndex = 112;
            lblNurses.Text = "Nurse/s:";
            // 
            // lblDoctors
            // 
            lblDoctors.AutoSize = true;
            lblDoctors.Location = new Point(3, 0);
            lblDoctors.Name = "lblDoctors";
            lblDoctors.Size = new Size(118, 30);
            lblDoctors.TabIndex = 110;
            lblDoctors.Text = "Doctor/s:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            label9.Location = new Point(1, 425);
            label9.Name = "label9";
            label9.Size = new Size(274, 43);
            label9.TabIndex = 106;
            label9.Text = "Room and Staff";
            // 
            // flowPatientInfo
            // 
            flowPatientInfo.Controls.Add(lblPatientID);
            flowPatientInfo.Controls.Add(lblAdmissionDate);
            flowPatientInfo.Controls.Add(lblName);
            flowPatientInfo.Controls.Add(panel2);
            flowPatientInfo.Controls.Add(lblPhone);
            flowPatientInfo.Controls.Add(lblEmail);
            flowPatientInfo.Controls.Add(lblAddress);
            flowPatientInfo.Controls.Add(lblEmergencyContact);
            flowPatientInfo.Controls.Add(lblEmergencyContactPhone);
            flowPatientInfo.FlowDirection = FlowDirection.TopDown;
            flowPatientInfo.Location = new Point(15, 58);
            flowPatientInfo.Name = "flowPatientInfo";
            flowPatientInfo.Size = new Size(609, 364);
            flowPatientInfo.TabIndex = 105;
            // 
            // lblAdmissionDate
            // 
            lblAdmissionDate.AutoSize = true;
            lblAdmissionDate.Location = new Point(3, 30);
            lblAdmissionDate.Name = "lblAdmissionDate";
            lblAdmissionDate.Size = new Size(186, 30);
            lblAdmissionDate.TabIndex = 10;
            lblAdmissionDate.Text = "Date Admitted:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft JhengHei UI", 14F);
            lblName.Location = new Point(3, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(87, 30);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDateOfBirth);
            panel2.Controls.Add(lblGender);
            panel2.Location = new Point(3, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 34);
            panel2.TabIndex = 5;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(306, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(168, 30);
            lblDateOfBirth.TabIndex = 1;
            lblDateOfBirth.Text = "Date of Birth: ";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(0, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(104, 30);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 130);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(98, 30);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(79, 30);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(3, 190);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(111, 30);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.AutoSize = true;
            lblEmergencyContact.Location = new Point(3, 220);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(240, 30);
            lblEmergencyContact.TabIndex = 8;
            lblEmergencyContact.Text = "Emergency Contact:";
            // 
            // lblEmergencyContactPhone
            // 
            lblEmergencyContactPhone.AutoSize = true;
            lblEmergencyContactPhone.Location = new Point(3, 250);
            lblEmergencyContactPhone.Name = "lblEmergencyContactPhone";
            lblEmergencyContactPhone.Size = new Size(319, 30);
            lblEmergencyContactPhone.TabIndex = 9;
            lblEmergencyContactPhone.Text = "Emergency Contact Phone:";
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            lblPatientInfo.Location = new Point(3, 3);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new Size(337, 43);
            lblPatientInfo.TabIndex = 101;
            lblPatientInfo.Text = "Patient Information";
            // 
            // panelMedRecord
            // 
            panelMedRecord.BackColor = SystemColors.Control;
            panelMedRecord.Controls.Add(label15);
            panelMedRecord.Controls.Add(flowMedicalRecords);
            panelMedRecord.Controls.Add(btnAddMedRecord);
            panelMedRecord.Location = new Point(704, 117);
            panelMedRecord.Name = "panelMedRecord";
            panelMedRecord.Size = new Size(754, 847);
            panelMedRecord.TabIndex = 100;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            label15.Location = new Point(3, 3);
            label15.Name = "label15";
            label15.Size = new Size(289, 43);
            label15.TabIndex = 109;
            label15.Text = "Medical Records";
            // 
            // flowMedicalRecords
            // 
            flowMedicalRecords.AutoScroll = true;
            flowMedicalRecords.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowMedicalRecords.FlowDirection = FlowDirection.TopDown;
            flowMedicalRecords.Location = new Point(15, 58);
            flowMedicalRecords.Name = "flowMedicalRecords";
            flowMedicalRecords.Size = new Size(725, 700);
            flowMedicalRecords.TabIndex = 102;
            flowMedicalRecords.WrapContents = false;
            // 
            // btnAddMedRecord
            // 
            btnAddMedRecord.Font = new Font("Microsoft JhengHei UI", 14F);
            btnAddMedRecord.Location = new Point(471, 784);
            btnAddMedRecord.Name = "btnAddMedRecord";
            btnAddMedRecord.Size = new Size(280, 60);
            btnAddMedRecord.TabIndex = 101;
            btnAddMedRecord.Text = "Add Medical Record";
            btnAddMedRecord.UseVisualStyleBackColor = true;
            // 
            // PatientRecord
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(panelMedRecord);
            Controls.Add(panelPatientInfo);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 16.2F);
            Margin = new Padding(5);
            Name = "PatientRecord";
            Size = new Size(1520, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelPatientInfo.ResumeLayout(false);
            panelPatientInfo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowPatientInfo.ResumeLayout(false);
            flowPatientInfo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelMedRecord.ResumeLayout(false);
            panelMedRecord.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Label lblPatientID;
        private Panel panelPatientInfo;
        private Panel panelMedRecord;
        private Button btnAddMedRecord;
        private Label lblName;
        private Label lblPatientInfo;
        private FlowLayoutPanel flowPatientInfo;
        private Label lblGender;
        private Panel panel2;
        private Label lblDateOfBirth;
        private Label lblAdmissionDate;
        private Label lblPhone;
        private Label lblAddress;
        private Label lblEmergencyContact;
        private Label lblEmergencyContactPhone;
        private Label label9;
        private Label lblRoom;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblBedNo;
        private Panel panel3;
        private Label lblEndDate;
        private Label lblStartDate;
        private Panel panel4;
        private Label lblNurses;
        private Label lblDoctors;
        private Button button2;
        private Button button1;
        private RichTextBox textboxNurses;
        private RichTextBox textboxDoctors;
        private Label label15;
        private FlowLayoutPanel flowMedicalRecords;
        private Label lblEmail;
    }
}
