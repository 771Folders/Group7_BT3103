namespace EventDriven.Project.UI.UserControls
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
            panel1.SuspendLayout();
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
            lblPatientID.ForeColor = Color.White;
            lblPatientID.Location = new Point(60, 138);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(220, 36);
            lblPatientID.TabIndex = 99;
            lblPatientID.Text = "Patient ID: 1000";
            // 
            // PatientRecord
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(lblPatientID);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 16.2F);
            Margin = new Padding(5);
            Name = "PatientRecord";
            Size = new Size(1520, 1000);
            Load += PatientRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Label lblPatientID;
    }
}
