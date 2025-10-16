namespace TrinityCareMedica.UI
{
    partial class FormDoctorAssignment
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
            labelPatientID = new Label();
            labelName = new Label();
            label1 = new Label();
            cbDoctor1 = new ComboBox();
            cbDoctor2 = new ComboBox();
            cbDoctor3 = new ComboBox();
            cbNurse3 = new ComboBox();
            cbNurse2 = new ComboBox();
            cbNurse1 = new ComboBox();
            label2 = new Label();
            buttonAssign = new Button();
            buttonCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelPatientID
            // 
            labelPatientID.AutoSize = true;
            labelPatientID.Location = new Point(14, 9);
            labelPatientID.Margin = new Padding(5, 0, 5, 0);
            labelPatientID.Name = "labelPatientID";
            labelPatientID.Size = new Size(130, 30);
            labelPatientID.TabIndex = 0;
            labelPatientID.Text = "Patient ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(14, 39);
            labelName.Name = "labelName";
            labelName.Size = new Size(87, 30);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 69);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 2;
            label1.Text = "Doctor/s:";
            // 
            // cbDoctor1
            // 
            cbDoctor1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor1.FormattingEnabled = true;
            cbDoctor1.Location = new Point(138, 69);
            cbDoctor1.Name = "cbDoctor1";
            cbDoctor1.Size = new Size(306, 37);
            cbDoctor1.TabIndex = 3;
            cbDoctor1.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbDoctor2
            // 
            cbDoctor2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor2.FormattingEnabled = true;
            cbDoctor2.Location = new Point(138, 112);
            cbDoctor2.Name = "cbDoctor2";
            cbDoctor2.Size = new Size(306, 37);
            cbDoctor2.TabIndex = 4;
            cbDoctor2.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbDoctor3
            // 
            cbDoctor3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor3.FormattingEnabled = true;
            cbDoctor3.Location = new Point(138, 155);
            cbDoctor3.Name = "cbDoctor3";
            cbDoctor3.Size = new Size(306, 37);
            cbDoctor3.TabIndex = 5;
            cbDoctor3.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbNurse3
            // 
            cbNurse3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNurse3.FormattingEnabled = true;
            cbNurse3.Location = new Point(136, 304);
            cbNurse3.Name = "cbNurse3";
            cbNurse3.Size = new Size(306, 37);
            cbNurse3.TabIndex = 9;
            cbNurse3.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbNurse2
            // 
            cbNurse2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNurse2.FormattingEnabled = true;
            cbNurse2.Location = new Point(136, 261);
            cbNurse2.Name = "cbNurse2";
            cbNurse2.Size = new Size(306, 37);
            cbNurse2.TabIndex = 8;
            cbNurse2.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // cbNurse1
            // 
            cbNurse1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNurse1.FormattingEnabled = true;
            cbNurse1.Location = new Point(136, 218);
            cbNurse1.Name = "cbNurse1";
            cbNurse1.Size = new Size(306, 37);
            cbNurse1.TabIndex = 7;
            cbNurse1.SelectedIndexChanged += SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 6;
            label2.Text = "Nurse/s:";
            // 
            // buttonAssign
            // 
            buttonAssign.ForeColor = SystemColors.ControlText;
            buttonAssign.Location = new Point(656, 400);
            buttonAssign.Name = "buttonAssign";
            buttonAssign.Size = new Size(132, 38);
            buttonAssign.TabIndex = 10;
            buttonAssign.Text = "Assign";
            buttonAssign.UseVisualStyleBackColor = true;
            buttonAssign.Click += buttonAssign_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.ForeColor = SystemColors.ControlText;
            buttonCancel.Location = new Point(518, 400);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(132, 38);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonAssign);
            panel1.Controls.Add(labelPatientID);
            panel1.Controls.Add(cbNurse3);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(cbNurse2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbNurse1);
            panel1.Controls.Add(cbDoctor1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbDoctor2);
            panel1.Controls.Add(cbDoctor3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 12;
            // 
            // FormDoctorAssignment
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormDoctorAssignment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDoctorAssignment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelPatientID;
        private Label labelName;
        private Label label1;
        private ComboBox cbDoctor1;
        private ComboBox cbDoctor2;
        private ComboBox cbDoctor3;
        private ComboBox cbNurse3;
        private ComboBox cbNurse2;
        private ComboBox cbNurse1;
        private Label label2;
        private Button buttonAssign;
        private Button buttonCancel;
        private Panel panel1;
    }
}