namespace TrinityCareMedica.UI.AssignmentForms
{
    partial class FormAddMedicalRecord
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
            btnAdd = new Button();
            btnCancel = new Button();
            btnAddTreatment = new Button();
            btnAddMedication = new Button();
            txtNotes = new TextBox();
            label2 = new Label();
            txtDiagnosis = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnAddTreatment);
            panel1.Controls.Add(btnAddMedication);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDiagnosis);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 363);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.WindowText;
            btnAdd.Location = new Point(568, 286);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(438, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 42);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddTreatment
            // 
            btnAddTreatment.ForeColor = SystemColors.WindowText;
            btnAddTreatment.Location = new Point(473, 163);
            btnAddTreatment.Name = "btnAddTreatment";
            btnAddTreatment.Size = new Size(215, 42);
            btnAddTreatment.TabIndex = 5;
            btnAddTreatment.Text = "Add Treatment";
            btnAddTreatment.UseVisualStyleBackColor = true;
            btnAddTreatment.Click += btnAddTreatment_Click;
            // 
            // btnAddMedication
            // 
            btnAddMedication.ForeColor = SystemColors.WindowText;
            btnAddMedication.Location = new Point(473, 105);
            btnAddMedication.Name = "btnAddMedication";
            btnAddMedication.Size = new Size(215, 42);
            btnAddMedication.TabIndex = 4;
            btnAddMedication.Text = "Add Medication";
            btnAddMedication.UseVisualStyleBackColor = true;
            btnAddMedication.Click += btnAddMedication_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(43, 178);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Remarks";
            txtNotes.Size = new Size(345, 150);
            txtNotes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(43, 145);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 2;
            label2.Text = "Notes:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(43, 105);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.PlaceholderText = "e.g. Hypertension";
            txtDiagnosis.Size = new Size(345, 37);
            txtDiagnosis.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 72);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 0;
            label1.Text = "Diagnosis:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(743, 60);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(241, 30);
            label3.TabIndex = 0;
            label3.Text = "Add Medical Record";
            // 
            // FormAddMedicalRecord
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(743, 363);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAddMedicalRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddMedicalRecord";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAdd;
        private Button btnCancel;
        private Button btnAddTreatment;
        private Button btnAddMedication;
        private TextBox txtNotes;
        private Label label2;
        private TextBox txtDiagnosis;
        private Panel panel2;
        private Label label3;
    }
}