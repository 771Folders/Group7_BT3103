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
            labelDoctor = new Label();
            labelRoom = new Label();
            labelRecordDate = new Label();
            labelRecordID = new Label();
            labelDiagnosis = new Label();
            label6 = new Label();
            textboxNotes = new TextBox();
            label7 = new Label();
            textboxMedications = new TextBox();
            textboxTreatments = new TextBox();
            label8 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Location = new Point(3, 66);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(69, 22);
            labelDoctor.TabIndex = 3;
            labelDoctor.Text = "Doctor:";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(3, 44);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(67, 22);
            labelRoom.TabIndex = 2;
            labelRoom.Text = "Room: ";
            // 
            // labelRecordDate
            // 
            labelRecordDate.AutoSize = true;
            labelRecordDate.Location = new Point(3, 22);
            labelRecordDate.Name = "labelRecordDate";
            labelRecordDate.Size = new Size(104, 22);
            labelRecordDate.TabIndex = 1;
            labelRecordDate.Text = "01/01/2025";
            // 
            // labelRecordID
            // 
            labelRecordID.AutoSize = true;
            labelRecordID.Location = new Point(3, 0);
            labelRecordID.Name = "labelRecordID";
            labelRecordID.Size = new Size(82, 22);
            labelRecordID.TabIndex = 0;
            labelRecordID.Text = "Record #";
            // 
            // labelDiagnosis
            // 
            labelDiagnosis.AutoSize = true;
            labelDiagnosis.Location = new Point(173, 16);
            labelDiagnosis.Name = "labelDiagnosis";
            labelDiagnosis.Size = new Size(92, 22);
            labelDiagnosis.TabIndex = 2;
            labelDiagnosis.Text = "Diagnosis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 38);
            label6.Name = "label6";
            label6.Size = new Size(63, 22);
            label6.TabIndex = 4;
            label6.Text = "Notes:";
            // 
            // textboxNotes
            // 
            textboxNotes.BorderStyle = BorderStyle.None;
            textboxNotes.Location = new Point(180, 63);
            textboxNotes.Multiline = true;
            textboxNotes.Name = "textboxNotes";
            textboxNotes.ReadOnly = true;
            textboxNotes.ScrollBars = ScrollBars.Vertical;
            textboxNotes.Size = new Size(203, 134);
            textboxNotes.TabIndex = 5;
            textboxNotes.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(386, 16);
            label7.Name = "label7";
            label7.Size = new Size(111, 22);
            label7.TabIndex = 6;
            label7.Text = "Medications:";
            // 
            // textboxMedications
            // 
            textboxMedications.BorderStyle = BorderStyle.None;
            textboxMedications.Location = new Point(499, 17);
            textboxMedications.Multiline = true;
            textboxMedications.Name = "textboxMedications";
            textboxMedications.ReadOnly = true;
            textboxMedications.ScrollBars = ScrollBars.Vertical;
            textboxMedications.Size = new Size(218, 74);
            textboxMedications.TabIndex = 7;
            textboxMedications.TabStop = false;
            // 
            // textboxTreatments
            // 
            textboxTreatments.BorderStyle = BorderStyle.None;
            textboxTreatments.Location = new Point(499, 110);
            textboxTreatments.Multiline = true;
            textboxTreatments.Name = "textboxTreatments";
            textboxTreatments.ReadOnly = true;
            textboxTreatments.ScrollBars = ScrollBars.Vertical;
            textboxTreatments.Size = new Size(218, 87);
            textboxTreatments.TabIndex = 8;
            textboxTreatments.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(389, 110);
            label8.Name = "label8";
            label8.Size = new Size(105, 22);
            label8.TabIndex = 9;
            label8.Text = "Treatments:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(labelRecordID);
            flowLayoutPanel1.Controls.Add(labelRecordDate);
            flowLayoutPanel1.Controls.Add(labelRoom);
            flowLayoutPanel1.Controls.Add(labelDoctor);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(171, 194);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // MedicalRecordCard
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label8);
            Controls.Add(textboxTreatments);
            Controls.Add(textboxMedications);
            Controls.Add(label7);
            Controls.Add(textboxNotes);
            Controls.Add(label6);
            Controls.Add(labelDiagnosis);
            Font = new Font("Microsoft JhengHei UI", 10F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MedicalRecordCard";
            Size = new Size(715, 200);
            Load += MedicalRecordCard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelDoctor;
        private Label labelRoom;
        private Label labelRecordDate;
        private Label labelRecordID;
        private Label labelDiagnosis;
        private Label label6;
        private TextBox textboxNotes;
        private Label label7;
        private TextBox textboxMedications;
        private TextBox textboxTreatments;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
