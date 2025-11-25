namespace TrinityCareMedica.UI.UserControls
{
    partial class Discharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discharge));
            panel1 = new Panel();
            labelTitle = new Label();
            panel2 = new Panel();
            lblDiagnosis = new Label();
            lblDischargeDate = new Label();
            lblAdmissionDate = new Label();
            lblPatientID = new Label();
            lblPatientName = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(60, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 60);
            panel1.TabIndex = 99;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 22F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(13, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(368, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Discharge Summary";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblDiagnosis);
            panel2.Controls.Add(lblDischargeDate);
            panel2.Controls.Add(lblAdmissionDate);
            panel2.Controls.Add(lblPatientID);
            panel2.Controls.Add(lblPatientName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(60, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 743);
            panel2.TabIndex = 101;
            // 
            // lblDiagnosis
            // 
            lblDiagnosis.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiagnosis.Location = new Point(859, 632);
            lblDiagnosis.Name = "lblDiagnosis";
            lblDiagnosis.Size = new Size(460, 38);
            lblDiagnosis.TabIndex = 109;
            lblDiagnosis.Text = "--";
            lblDiagnosis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDischargeDate
            // 
            lblDischargeDate.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDischargeDate.Location = new Point(859, 492);
            lblDischargeDate.Name = "lblDischargeDate";
            lblDischargeDate.Size = new Size(460, 38);
            lblDischargeDate.TabIndex = 108;
            lblDischargeDate.Text = "--";
            lblDischargeDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAdmissionDate
            // 
            lblAdmissionDate.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdmissionDate.Location = new Point(859, 352);
            lblAdmissionDate.Name = "lblAdmissionDate";
            lblAdmissionDate.Size = new Size(460, 38);
            lblAdmissionDate.TabIndex = 107;
            lblAdmissionDate.Text = "--";
            lblAdmissionDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPatientID
            // 
            lblPatientID.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(859, 212);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(460, 38);
            lblPatientID.TabIndex = 106;
            lblPatientID.Text = "--";
            lblPatientID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPatientName
            // 
            lblPatientName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(859, 72);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(460, 38);
            lblPatientName.TabIndex = 105;
            lblPatientName.Text = "--";
            lblPatientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 632);
            label5.Name = "label5";
            label5.Size = new Size(163, 38);
            label5.TabIndex = 103;
            label5.Text = "Diagnosis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 492);
            label4.Name = "label4";
            label4.Size = new Size(240, 38);
            label4.TabIndex = 102;
            label4.Text = "Discharge Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 352);
            label3.Name = "label3";
            label3.Size = new Size(248, 38);
            label3.TabIndex = 101;
            label3.Text = "Admission Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 212);
            label2.Name = "label2";
            label2.Size = new Size(163, 38);
            label2.TabIndex = 100;
            label2.Text = "Patient ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 72);
            label1.Name = "label1";
            label1.Size = new Size(109, 38);
            label1.TabIndex = 99;
            label1.Text = "Name:";
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(1113, 918);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(347, 45);
            btnPrint.TabIndex = 102;
            btnPrint.Text = "Print Discharge Summary";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.ShowIcon = false;
            printPreviewDialog1.Visible = false;
            // 
            // Discharge
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(btnPrint);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Discharge";
            Size = new Size(1520, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Panel panel2;
        private Label lblDiagnosis;
        private Label lblDischargeDate;
        private Label lblAdmissionDate;
        private Label lblPatientID;
        private Label lblPatientName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
