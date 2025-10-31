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
            txtNurses = new TextBox();
            txtDoctors = new TextBox();
            label17 = new Label();
            label16 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label12 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            label15 = new Label();
            label14 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            labelPatientID = new Label();
            labelDateRegistered = new Label();
            labelFullName = new Label();
            labelDateOfBirth = new Label();
            labelAge = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelAddress = new Label();
            labelEmergencyContact = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            panel2.Controls.Add(txtNurses);
            panel2.Controls.Add(txtDoctors);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(60, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(695, 830);
            panel2.TabIndex = 99;
            // 
            // txtNurses
            // 
            txtNurses.Location = new Point(362, 615);
            txtNurses.Multiline = true;
            txtNurses.Name = "txtNurses";
            txtNurses.ReadOnly = true;
            txtNurses.Size = new Size(320, 202);
            txtNurses.TabIndex = 7;
            // 
            // txtDoctors
            // 
            txtDoctors.Location = new Point(19, 615);
            txtDoctors.Multiline = true;
            txtDoctors.Name = "txtDoctors";
            txtDoctors.ReadOnly = true;
            txtDoctors.Size = new Size(320, 202);
            txtDoctors.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(362, 576);
            label17.Name = "label17";
            label17.Size = new Size(113, 36);
            label17.TabIndex = 5;
            label17.Text = "Nurses:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 576);
            label16.Name = "label16";
            label16.Size = new Size(125, 36);
            label16.TabIndex = 4;
            label16.Text = "Doctors:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label12);
            flowLayoutPanel2.Controls.Add(label13);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(13, 459);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(669, 114);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(207, 36);
            label12.TabIndex = 4;
            label12.Text = "Current Room:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 36);
            label13.Name = "label13";
            label13.Size = new Size(189, 36);
            label13.TabIndex = 5;
            label13.Text = "Bed Number:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(3, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(666, 36);
            panel4.TabIndex = 6;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(296, 2);
            label15.Name = "label15";
            label15.Size = new Size(140, 36);
            label15.TabIndex = 5;
            label15.Text = "End Date:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(151, 36);
            label14.TabIndex = 4;
            label14.Text = "Start Date:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelPatientID);
            flowLayoutPanel1.Controls.Add(labelDateRegistered);
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
            // labelDateRegistered
            // 
            labelDateRegistered.AutoSize = true;
            labelDateRegistered.Location = new Point(3, 36);
            labelDateRegistered.Name = "labelDateRegistered";
            labelDateRegistered.Size = new Size(232, 36);
            labelDateRegistered.TabIndex = 10;
            labelDateRegistered.Text = "Date Registered:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(3, 72);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(154, 36);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "Full Name:";
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(3, 108);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(185, 36);
            labelDateOfBirth.TabIndex = 2;
            labelDateOfBirth.Text = "Date of Birth:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(3, 144);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(74, 36);
            labelAge.TabIndex = 3;
            labelAge.Text = "Age:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(3, 180);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(119, 36);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(3, 216);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(106, 36);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(3, 252);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(91, 36);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(3, 288);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(128, 36);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address:";
            // 
            // labelEmergencyContact
            // 
            labelEmergencyContact.AutoSize = true;
            labelEmergencyContact.Location = new Point(3, 324);
            labelEmergencyContact.Name = "labelEmergencyContact";
            labelEmergencyContact.Size = new Size(278, 36);
            labelEmergencyContact.TabIndex = 8;
            labelEmergencyContact.Text = "Emergency Contact:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Location = new Point(765, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 830);
            panel3.TabIndex = 100;
            // 
            // PatientRecord
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
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
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
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
        private Label labelDateRegistered;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label12;
        private Label label13;
        private Panel panel4;
        private Label label14;
        private TextBox txtNurses;
        private TextBox txtDoctors;
        private Label label17;
        private Label label16;
        private Label label15;
    }
}
