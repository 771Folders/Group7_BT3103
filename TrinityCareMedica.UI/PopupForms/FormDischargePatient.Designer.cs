namespace TrinityCareMedica.UI.PopupForms
{
    partial class FormDischargePatient
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
            btnCancel = new Button();
            btnDischarge = new Button();
            txtPatientName = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnDischarge);
            panel1.Controls.Add(txtPatientName);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(810, 144);
            panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(666, 84);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 37);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDischarge
            // 
            btnDischarge.ForeColor = SystemColors.ControlText;
            btnDischarge.Location = new Point(514, 83);
            btnDischarge.Name = "btnDischarge";
            btnDischarge.Size = new Size(146, 38);
            btnDischarge.TabIndex = 5;
            btnDischarge.Text = "Discharge";
            btnDischarge.UseVisualStyleBackColor = true;
            btnDischarge.Click += btnDischarge_Click;
            // 
            // txtPatientName
            // 
            txtPatientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPatientName.Location = new Point(22, 84);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.PlaceholderText = "Enter Patient Name";
            txtPatientName.Size = new Size(486, 37);
            txtPatientName.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 60);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(212, 30);
            label3.TabIndex = 0;
            label3.Text = "Discharge Patient";
            // 
            // FormDischargePatient
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(810, 144);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormDischargePatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDischargePatient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnDischarge;
        private TextBox txtPatientName;
        private Panel panel2;
        private Label label3;
    }
}