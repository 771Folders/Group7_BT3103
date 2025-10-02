using EventDriven.Project.UI.CustomControls;

namespace EventDriven.Project.UI
{
    partial class FormAdmission
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new CustomPanel();
            button5 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            label5 = new Label();
            label6 = new Label();
            txtLastName = new TextBox();
            label7 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            drpdownGender = new ComboBox();
            dateDOB = new DateTimePicker();
            txtGuardian = new TextBox();
            label13 = new Label();
            txtAddress = new TextBox();
            label14 = new Label();
            txtGuardianPhone = new TextBox();
            label15 = new Label();
            label18 = new Label();
            label20 = new Label();
            checkboxTandC = new CheckBox();
            label21 = new Label();
            dateAdmissionDate = new DateTimePicker();
            btnReset = new Button();
            btnSubmit = new Button();
            txtFirstName = new TextBox();
            label22 = new Label();
            txtMiddleName = new TextBox();
            label23 = new Label();
            panel3 = new Panel();
            btnAddDoctor = new Button();
            txtPatientID = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 60);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1902, 60);
            label2.TabIndex = 0;
            label2.Text = "TrinityCare Medica";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderColor = Color.Black;
            panel2.BorderRadius = 0;
            panel2.BorderThickness = 0;
            panel2.ColorBottom = Color.MediumTurquoise;
            panel2.ColorTop = Color.White;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Microsoft JhengHei UI", 9F);
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 973);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Font = new Font("Microsoft JhengHei UI", 14F);
            button5.Location = new Point(112, 877);
            button5.Name = "button5";
            button5.Size = new Size(146, 46);
            button5.TabIndex = 5;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(12, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(368, 587);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft JhengHei UI", 14F);
            button1.Image = Properties.Resources._1000065903;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(364, 121);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft JhengHei UI", 14F);
            button3.Image = Properties.Resources._1000065901;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 130);
            button3.Name = "button3";
            button3.Size = new Size(364, 121);
            button3.TabIndex = 2;
            button3.Text = "Patient Information\r\nMaintenance";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft JhengHei UI", 14F);
            button2.Image = Properties.Resources._1000065902;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 257);
            button2.Name = "button2";
            button2.Size = new Size(364, 121);
            button2.TabIndex = 3;
            button2.Text = "Admission";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft JhengHei UI", 14F);
            button4.Image = Properties.Resources._1000065900;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 384);
            button4.Name = "button4";
            button4.Size = new Size(364, 121);
            button4.TabIndex = 4;
            button4.Text = "     Treatment/ Billing Breakdown";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(29, 158);
            label5.Name = "label5";
            label5.Size = new Size(303, 38);
            label5.TabIndex = 24;
            label5.Text = "Patient Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(328, 147);
            label6.Name = "label6";
            label6.Size = new Size(1161, 38);
            label6.TabIndex = 25;
            label6.Text = "________________________________________________________________________________________";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(29, 265);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(390, 43);
            txtLastName.TabIndex = 6;
            txtLastName.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(29, 226);
            label7.Name = "label7";
            label7.Size = new Size(160, 36);
            label7.TabIndex = 26;
            label7.Text = "Last Name:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(626, 388);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(374, 43);
            txtPhone.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(626, 349);
            label8.Name = "label8";
            label8.Size = new Size(223, 36);
            label8.TabIndex = 28;
            label8.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(1014, 389);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(447, 43);
            txtEmail.TabIndex = 13;
            txtEmail.WordWrap = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(1014, 338);
            label9.Name = "label9";
            label9.Size = new Size(91, 36);
            label9.TabIndex = 30;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(29, 346);
            label10.Name = "label10";
            label10.Size = new Size(185, 36);
            label10.TabIndex = 32;
            label10.Text = "Date of Birth:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(328, 348);
            label11.Name = "label11";
            label11.Size = new Size(119, 36);
            label11.TabIndex = 34;
            label11.Text = "Gender:";
            // 
            // drpdownGender
            // 
            drpdownGender.AllowDrop = true;
            drpdownGender.DropDownStyle = ComboBoxStyle.DropDownList;
            drpdownGender.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            drpdownGender.FormattingEnabled = true;
            drpdownGender.ItemHeight = 37;
            drpdownGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer not to say" });
            drpdownGender.Location = new Point(328, 387);
            drpdownGender.Name = "drpdownGender";
            drpdownGender.Size = new Size(285, 45);
            drpdownGender.TabIndex = 11;
            // 
            // dateDOB
            // 
            dateDOB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateDOB.Format = DateTimePickerFormat.Short;
            dateDOB.Location = new Point(29, 387);
            dateDOB.Name = "dateDOB";
            dateDOB.Size = new Size(284, 43);
            dateDOB.TabIndex = 10;
            // 
            // txtGuardian
            // 
            txtGuardian.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardian.Location = new Point(29, 616);
            txtGuardian.Name = "txtGuardian";
            txtGuardian.Size = new Size(601, 43);
            txtGuardian.TabIndex = 15;
            txtGuardian.WordWrap = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(29, 577);
            label13.Name = "label13";
            label13.Size = new Size(345, 36);
            label13.TabIndex = 40;
            label13.Text = "Guardian/ Parents Name:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(29, 504);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(1432, 43);
            txtAddress.TabIndex = 14;
            txtAddress.WordWrap = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(29, 465);
            label14.Name = "label14";
            label14.Size = new Size(128, 36);
            label14.TabIndex = 42;
            label14.Text = "Address:";
            // 
            // txtGuardianPhone
            // 
            txtGuardianPhone.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianPhone.Location = new Point(667, 616);
            txtGuardianPhone.Multiline = true;
            txtGuardianPhone.Name = "txtGuardianPhone";
            txtGuardianPhone.Size = new Size(374, 43);
            txtGuardianPhone.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Transparent;
            label15.Location = new Point(667, 577);
            label15.Name = "label15";
            label15.Size = new Size(370, 36);
            label15.TabIndex = 44;
            label15.Text = "Guardian's Phone Number:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.LightGray;
            label18.Location = new Point(216, 694);
            label18.Name = "label18";
            label18.Size = new Size(1265, 38);
            label18.TabIndex = 53;
            label18.Text = "________________________________________________________________________________________________";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.White;
            label20.Location = new Point(29, 706);
            label20.Name = "label20";
            label20.Size = new Size(181, 38);
            label20.TabIndex = 52;
            label20.Text = "Agreement";
            // 
            // checkboxTandC
            // 
            checkboxTandC.AutoSize = true;
            checkboxTandC.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkboxTandC.ForeColor = Color.White;
            checkboxTandC.Location = new Point(48, 785);
            checkboxTandC.Name = "checkboxTandC";
            checkboxTandC.Size = new Size(460, 40);
            checkboxTandC.TabIndex = 18;
            checkboxTandC.Text = "I agree to terms and conditions*";
            checkboxTandC.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(1102, 746);
            label21.Name = "label21";
            label21.Size = new Size(228, 36);
            label21.TabIndex = 55;
            label21.Text = "Admission Date:";
            // 
            // dateAdmissionDate
            // 
            dateAdmissionDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateAdmissionDate.Format = DateTimePickerFormat.Short;
            dateAdmissionDate.Location = new Point(1102, 785);
            dateAdmissionDate.Name = "dateAdmissionDate";
            dateAdmissionDate.Size = new Size(374, 47);
            dateAdmissionDate.TabIndex = 19;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(1102, 850);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(175, 54);
            btnReset.TabIndex = 20;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button6_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(1301, 850);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(175, 54);
            btnSubmit.TabIndex = 21;
            btnSubmit.Text = "ADMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button7_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(439, 265);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(390, 43);
            txtFirstName.TabIndex = 7;
            txtFirstName.WordWrap = false;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(439, 226);
            label22.Name = "label22";
            label22.Size = new Size(163, 36);
            label22.TabIndex = 60;
            label22.Text = "First Name:";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(850, 265);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(390, 43);
            txtMiddleName.TabIndex = 8;
            txtMiddleName.WordWrap = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.White;
            label23.Location = new Point(850, 226);
            label23.Name = "label23";
            label23.Size = new Size(201, 36);
            label23.TabIndex = 62;
            label23.Text = "Middle Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.BackgroundImage = Properties.Resources.Untitled_design__1__removebg_preview;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Controls.Add(btnAddDoctor);
            panel3.Controls.Add(txtPatientID);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtMiddleName);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(btnSubmit);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(dateAdmissionDate);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(checkboxTandC);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtGuardianPhone);
            panel3.Controls.Add(drpdownGender);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(dateDOB);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtGuardian);
            panel3.Controls.Add(label13);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(394, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1508, 973);
            panel3.TabIndex = 64;
            // 
            // btnAddDoctor
            // 
            btnAddDoctor.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDoctor.Location = new Point(1085, 611);
            btnAddDoctor.Name = "btnAddDoctor";
            btnAddDoctor.Size = new Size(376, 54);
            btnAddDoctor.TabIndex = 17;
            btnAddDoctor.Text = "Assign Doctors/Nurses";
            btnAddDoctor.UseVisualStyleBackColor = true;
            // 
            // txtPatientID
            // 
            txtPatientID.BackColor = SystemColors.Window;
            txtPatientID.Enabled = false;
            txtPatientID.Font = new Font("Segoe UI", 16.2F);
            txtPatientID.Location = new Point(1272, 265);
            txtPatientID.Name = "txtPatientID";
            txtPatientID.ReadOnly = true;
            txtPatientID.Size = new Size(189, 43);
            txtPatientID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1272, 227);
            label3.Name = "label3";
            label3.Size = new Size(149, 36);
            label3.TabIndex = 65;
            label3.Text = "Patient ID:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(29, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(1452, 68);
            panel4.TabIndex = 64;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 22F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(203, 47);
            label1.TabIndex = 0;
            label1.Text = "Admission";
            // 
            // FormAdmission
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdmission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdmission";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CustomPanel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txtLastName;
        private Label label7;
        private TextBox txtPhone;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox drpdownGender;
        private DateTimePicker dateDOB;
        private TextBox txtGuardian;
        private Label label13;
        private TextBox txtAddress;
        private Label label14;
        private TextBox txtGuardianPhone;
        private Label label15;
        private Label label18;
        private Label label20;
        private CheckBox checkboxTandC;
        private Label label21;
        private DateTimePicker dateAdmissionDate;
        private Button btnReset;
        private Button btnSubmit;
        private TextBox txtFirstName;
        private Label label22;
        private TextBox txtMiddleName;
        private Label label23;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label3;
        private TextBox txtPatientID;
        private Button btnAddDoctor;
    }
}