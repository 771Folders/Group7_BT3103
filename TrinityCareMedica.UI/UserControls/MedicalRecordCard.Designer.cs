namespace TrinityCareMedica.UI.UserControls
{
    partial class MedicalRecordCard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblRecordDate = new Label();
            label6 = new Label();
            txtDiagnosis = new TextBox();
            txtNotes = new TextBox();
            txtTreatment = new TextBox();
            txtMedication = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 10F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 36);
            label1.Name = "label1";
            label1.Size = new Size(92, 22);
            label1.TabIndex = 0;
            label1.Text = "Diagnosis:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 10F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(423, 12);
            label2.Name = "label2";
            label2.Size = new Size(113, 22);
            label2.TabIndex = 1;
            label2.Text = "Record Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 10F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(334, 36);
            label3.Name = "label3";
            label3.Size = new Size(97, 22);
            label3.TabIndex = 2;
            label3.Text = "Treatment:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 10F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(35, 176);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 6;
            label4.Text = "Medication:";
            // 
            // lblRecordDate
            // 
            lblRecordDate.AutoSize = true;
            lblRecordDate.Font = new Font("Microsoft JhengHei UI", 10F);
            lblRecordDate.ForeColor = SystemColors.ButtonHighlight;
            lblRecordDate.Location = new Point(531, 12);
            lblRecordDate.Name = "lblRecordDate";
            lblRecordDate.Size = new Size(84, 22);
            lblRecordDate.TabIndex = 7;
            lblRecordDate.Text = "10/10/25";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 10F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(334, 176);
            label6.Name = "label6";
            label6.Size = new Size(63, 22);
            label6.TabIndex = 8;
            label6.Text = "Notes:";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            txtDiagnosis.Location = new Point(35, 61);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ReadOnly = true;
            txtDiagnosis.Size = new Size(250, 100);
            txtDiagnosis.TabIndex = 9;
            txtDiagnosis.TabStop = false;
            txtDiagnosis.Enter += removeFocus;
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            txtNotes.Location = new Point(334, 201);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(250, 100);
            txtNotes.TabIndex = 10;
            txtNotes.TabStop = false;
            txtNotes.Enter += removeFocus;
            // 
            // txtTreatment
            // 
            txtTreatment.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            txtTreatment.Location = new Point(334, 61);
            txtTreatment.Multiline = true;
            txtTreatment.Name = "txtTreatment";
            txtTreatment.ReadOnly = true;
            txtTreatment.Size = new Size(250, 100);
            txtTreatment.TabIndex = 11;
            txtTreatment.TabStop = false;
            txtTreatment.Enter += removeFocus;
            // 
            // txtMedication
            // 
            txtMedication.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold);
            txtMedication.Location = new Point(35, 201);
            txtMedication.Multiline = true;
            txtMedication.Name = "txtMedication";
            txtMedication.ReadOnly = true;
            txtMedication.Size = new Size(250, 100);
            txtMedication.TabIndex = 12;
            txtMedication.TabStop = false;
            txtMedication.Enter += removeFocus;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft JhengHei UI", 10F);
            btnDelete.Location = new Point(531, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(84, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MedicalRecordCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            Controls.Add(btnDelete);
            Controls.Add(txtMedication);
            Controls.Add(txtTreatment);
            Controls.Add(txtNotes);
            Controls.Add(txtDiagnosis);
            Controls.Add(label6);
            Controls.Add(lblRecordDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MedicalRecordCard";
            Size = new Size(635, 362);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblRecordDate;
        private Label label6;
        private TextBox txtDiagnosis;
        private TextBox txtNotes;
        private TextBox txtTreatment;
        private TextBox txtMedication;
        private Button btnDelete;
    }
}
