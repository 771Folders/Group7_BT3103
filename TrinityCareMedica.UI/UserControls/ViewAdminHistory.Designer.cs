namespace TrinityCareMedica.UI.UserControls
{
    partial class ViewAdminHistory
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            labelTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Silver;
            flowLayoutPanel1.Location = new Point(60, 125);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1400, 829);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(60, 50);
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
            labelTitle.Size = new Size(336, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admission History";
            // 
            // ViewAdminHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "ViewAdminHistory";
            Size = new Size(1520, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label labelTitle;
    }
}
