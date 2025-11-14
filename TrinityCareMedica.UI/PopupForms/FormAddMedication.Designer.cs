namespace TrinityCareMedica.UI.AssignmentForms
{
    partial class FormAddMedication
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
            panel2 = new Panel();
            label3 = new Label();
            txtMedicationName = new TextBox();
            label1 = new Label();
            txtCount = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtInterval = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtDuration = new TextBox();
            label7 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            txtPrice = new TextBox();
            label8 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 60);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(194, 30);
            label3.TabIndex = 0;
            label3.Text = "Add Medication";
            // 
            // txtMedicationName
            // 
            txtMedicationName.Location = new Point(28, 109);
            txtMedicationName.Name = "txtMedicationName";
            txtMedicationName.PlaceholderText = "e.g. Amlodipine 5mg";
            txtMedicationName.Size = new Size(362, 37);
            txtMedicationName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 76);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 3;
            label1.Text = "Medication:";
            // 
            // txtCount
            // 
            txtCount.Location = new Point(28, 182);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(46, 37);
            txtCount.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(28, 149);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 5;
            label2.Text = "Frequency:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(80, 185);
            label4.Name = "label4";
            label4.Size = new Size(73, 30);
            label4.TabIndex = 7;
            label4.Text = "Every";
            // 
            // txtInterval
            // 
            txtInterval.Location = new Point(159, 182);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(46, 37);
            txtInterval.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(211, 185);
            label5.Name = "label5";
            label5.Size = new Size(81, 30);
            label5.TabIndex = 9;
            label5.Text = "Hours";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(28, 222);
            label6.Name = "label6";
            label6.Size = new Size(119, 30);
            label6.TabIndex = 10;
            label6.Text = "Duration:";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(28, 255);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(46, 37);
            txtDuration.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(80, 258);
            label7.Name = "label7";
            label7.Size = new Size(67, 30);
            label7.TabIndex = 12;
            label7.Text = "Days";
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.WindowText;
            btnAdd.Location = new Point(427, 325);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 42);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(297, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 42);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDuration);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtInterval);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtCount);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMedicationName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 380);
            panel1.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(217, 258);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(173, 37);
            txtPrice.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(217, 225);
            label8.Name = "label8";
            label8.Size = new Size(74, 30);
            label8.TabIndex = 15;
            label8.Text = "Price:";
            // 
            // FormAddMedication
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(560, 380);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAddMedication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddMedication";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private TextBox txtMedicationName;
        private Label label1;
        private TextBox txtCount;
        private Label label2;
        private Label label4;
        private TextBox txtInterval;
        private Label label5;
        private Label label6;
        private TextBox txtDuration;
        private Label label7;
        private Button btnAdd;
        private Button btnCancel;
        private Panel panel1;
        private TextBox txtPrice;
        private Label label8;
    }
}