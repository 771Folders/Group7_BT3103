namespace EventDriven.Project.UI.UserControls
{
    partial class Admission
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
            btnAddDoctor = new Button();
            label3 = new Label();
            panel4 = new Panel();
            labelTitle = new Label();
            txtMiddleName = new TextBox();
            label18 = new Label();
            label23 = new Label();
            txtFirstName = new TextBox();
            label22 = new Label();
            btnSubmit = new Button();
            btnReset = new Button();
            dateAdmissionDate = new DateTimePicker();
            label21 = new Label();
            label5 = new Label();
            checkboxTandC = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label20 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            label11 = new Label();
            txtGuardianPhone = new TextBox();
            drpdownGender = new ComboBox();
            label15 = new Label();
            dateBirth = new DateTimePicker();
            txtAddress = new TextBox();
            label14 = new Label();
            txtGuardian = new TextBox();
            label13 = new Label();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            lblID = new Label();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDoctor.Location = new Point(1115, 666);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(340, 54);
            btnAddDoctor.TabIndex = 77;
            btnAddDoctor.Text = "Assign Doctors/Nurses";
            btnAddDoctor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 193);
            label3.Name = "label3";
            label3.Size = new Size(149, 36);
            label3.TabIndex = 98;
            label3.Text = "Patient ID:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(labelTitle);
            panel4.Location = new Point(60, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(1400, 60);
            panel4.TabIndex = 97;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 22F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(13, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(203, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admission";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(1007, 320);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(446, 43);
            txtMiddleName.TabIndex = 68;
            txtMiddleName.WordWrap = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.LightGray;
            label18.Location = new Point(247, 749);
            label18.Name = "label18";
            label18.Size = new Size(1213, 38);
            label18.TabIndex = 93;
            label18.Text = "____________________________________________________________________________________________";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.White;
            label23.Location = new Point(1009, 281);
            label23.Name = "label23";
            label23.Size = new Size(201, 36);
            label23.TabIndex = 96;
            label23.Text = "Middle Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(535, 320);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(446, 43);
            txtFirstName.TabIndex = 67;
            txtFirstName.WordWrap = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(536, 281);
            label22.Name = "label22";
            label22.Size = new Size(163, 36);
            label22.TabIndex = 95;
            label22.Text = "First Name:";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1280, 898);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(175, 54);
            btnSubmit.TabIndex = 81;
            btnSubmit.Text = "ADMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(1081, 898);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(175, 54);
            btnReset.TabIndex = 80;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // dateAdmissionDate
            // 
            dateAdmissionDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dateAdmissionDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateAdmissionDate.Format = DateTimePickerFormat.Custom;
            dateAdmissionDate.Location = new Point(1081, 833);
            dateAdmissionDate.Name = "dateAdmissionDate";
            dateAdmissionDate.Size = new Size(374, 47);
            dateAdmissionDate.TabIndex = 79;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(1081, 794);
            label21.Name = "label21";
            label21.Size = new Size(228, 36);
            label21.TabIndex = 94;
            label21.Text = "Admission Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(65, 135);
            label5.Name = "label5";
            label5.Size = new Size(303, 38);
            label5.TabIndex = 82;
            label5.Text = "Patient Information";
            // 
            // checkboxTandC
            // 
            checkboxTandC.AutoSize = true;
            checkboxTandC.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkboxTandC.ForeColor = Color.White;
            checkboxTandC.Location = new Point(79, 840);
            checkboxTandC.Name = "checkboxTandC";
            checkboxTandC.Size = new Size(460, 40);
            checkboxTandC.TabIndex = 78;
            checkboxTandC.Text = "I agree to terms and conditions*";
            checkboxTandC.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(364, 124);
            label6.Name = "label6";
            label6.Size = new Size(1096, 38);
            label6.TabIndex = 83;
            label6.Text = "___________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(60, 281);
            label7.Name = "label7";
            label7.Size = new Size(160, 36);
            label7.TabIndex = 84;
            label7.Text = "Last Name:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(60, 761);
            label20.Name = "label20";
            label20.Size = new Size(181, 38);
            label20.TabIndex = 92;
            label20.Text = "Agreement";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(655, 412);
            label8.Name = "label8";
            label8.Size = new Size(223, 36);
            label8.TabIndex = 85;
            label8.Text = "Phone Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1007, 412);
            label9.Name = "label9";
            label9.Size = new Size(91, 36);
            label9.TabIndex = 86;
            label9.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(1007, 451);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(447, 43);
            txtEmail.TabIndex = 73;
            txtEmail.WordWrap = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(58, 412);
            label10.Name = "label10";
            label10.Size = new Size(185, 36);
            label10.TabIndex = 87;
            label10.Text = "Date of Birth:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(357, 412);
            label11.Name = "label11";
            label11.Size = new Size(119, 36);
            label11.TabIndex = 88;
            label11.Text = "Gender:";
            // 
            // txtGuardianPhone
            // 
            txtGuardianPhone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianPhone.Location = new Point(701, 671);
            txtGuardianPhone.Multiline = true;
            txtGuardianPhone.Name = "txtGuardianPhone";
            txtGuardianPhone.Size = new Size(374, 43);
            txtGuardianPhone.TabIndex = 76;
            // 
            // drpdownGender
            // 
            drpdownGender.AllowDrop = true;
            drpdownGender.DropDownStyle = ComboBoxStyle.DropDownList;
            drpdownGender.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drpdownGender.FormattingEnabled = true;
            drpdownGender.ItemHeight = 37;
            drpdownGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer not to say" });
            drpdownGender.Location = new Point(358, 450);
            drpdownGender.Name = "drpdownGender";
            drpdownGender.Size = new Size(285, 45);
            drpdownGender.TabIndex = 71;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(701, 632);
            label15.Name = "label15";
            label15.Size = new Size(370, 36);
            label15.TabIndex = 91;
            label15.Text = "Guardian's Phone Number:";
            // 
            // dateBirth
            // 
            dateBirth.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateBirth.Format = DateTimePickerFormat.Short;
            dateBirth.Location = new Point(60, 451);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(284, 43);
            dateBirth.TabIndex = 70;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(60, 559);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1395, 43);
            txtAddress.TabIndex = 74;
            txtAddress.WordWrap = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(60, 520);
            label14.Name = "label14";
            label14.Size = new Size(128, 36);
            label14.TabIndex = 90;
            label14.Text = "Address:";
            // 
            // txtGuardian
            // 
            txtGuardian.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardian.Location = new Point(60, 671);
            txtGuardian.Name = "txtGuardian";
            txtGuardian.Size = new Size(601, 43);
            txtGuardian.TabIndex = 75;
            txtGuardian.WordWrap = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(60, 632);
            label13.Name = "label13";
            label13.Size = new Size(345, 36);
            label13.TabIndex = 89;
            label13.Text = "Guardian/ Parents Name:";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(63, 320);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(446, 43);
            txtLastName.TabIndex = 66;
            txtLastName.WordWrap = false;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(657, 451);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(324, 43);
            txtPhone.TabIndex = 72;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Microsoft JhengHei UI", 16.2F);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(65, 229);
            lblID.Name = "lblID";
            lblID.Size = new Size(79, 36);
            lblID.TabIndex = 99;
            lblID.Text = "1000";
            // 
            // Admission
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            BackgroundImage = Properties.Resources.Untitled_design__1__removebg_preview;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(lblID);
            Controls.Add(btnAddDoctor);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(txtMiddleName);
            Controls.Add(label18);
            Controls.Add(label23);
            Controls.Add(txtFirstName);
            Controls.Add(label22);
            Controls.Add(btnSubmit);
            Controls.Add(btnReset);
            Controls.Add(dateAdmissionDate);
            Controls.Add(label21);
            Controls.Add(label5);
            Controls.Add(checkboxTandC);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label20);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(txtGuardianPhone);
            Controls.Add(drpdownGender);
            Controls.Add(label15);
            Controls.Add(dateBirth);
            Controls.Add(txtAddress);
            Controls.Add(label14);
            Controls.Add(txtGuardian);
            Controls.Add(label13);
            Controls.Add(txtLastName);
            Controls.Add(txtPhone);
            DoubleBuffered = true;
            Font = new Font("Microsoft JhengHei UI", 14F);
            Margin = new Padding(5);
            Name = "Admission";
            Size = new Size(1520, 1000);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDoctor;
        private Label label3;
        private Panel panel4;
        private Label labelTitle;
        private TextBox txtMiddleName;
        private Label label18;
        private Label label23;
        private TextBox txtFirstName;
        private Label label22;
        private Button btnSubmit;
        private Button btnReset;
        private DateTimePicker dateAdmissionDate;
        private Label label21;
        private Label label5;
        private CheckBox checkboxTandC;
        private Label label6;
        private Label label7;
        private Label label20;
        private Label label8;
        private Label label9;
        private TextBox txtEmail;
        private Label label10;
        private Label label11;
        private TextBox txtGuardianPhone;
        private ComboBox drpdownGender;
        private Label label15;
        private DateTimePicker dateBirth;
        private TextBox txtAddress;
        private Label label14;
        private TextBox txtGuardian;
        private Label label13;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private Label lblID;
    }
}
