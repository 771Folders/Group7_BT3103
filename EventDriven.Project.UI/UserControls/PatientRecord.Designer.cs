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
            panel4 = new Panel();
            labelTitle = new Label();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Teal;
            panel4.Controls.Add(labelTitle);
            panel4.Location = new Point(60, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(1400, 60);
            panel4.TabIndex = 98;
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
            // PatientRecord
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(panel4);
            Font = new Font("Microsoft JhengHei UI", 14F);
            Margin = new Padding(5);
            Name = "PatientRecord";
            Size = new Size(1520, 1000);
            Load += PatientRecord_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label labelTitle;
    }
}
