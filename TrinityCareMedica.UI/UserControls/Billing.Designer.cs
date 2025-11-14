namespace TrinityCareMedica.UI.UserControls
{
    partial class Billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            panel1 = new Panel();
            labelTitle = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label10 = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblPatientID = new Label();
            lblPatientName = new Label();
            label1 = new Label();
            btnPayment = new Button();
            btnPrint = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            labelTitle.Size = new Size(129, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Billing";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lblAge);
            panel2.Controls.Add(lblGender);
            panel2.Controls.Add(lblPatientID);
            panel2.Controls.Add(lblPatientName);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(61, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(1406, 770);
            panel2.TabIndex = 99;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(89, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1203, 399);
            dataGridView1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(89, 269);
            label10.Name = "label10";
            label10.Size = new Size(250, 36);
            label10.TabIndex = 9;
            label10.Text = "Billing Statement";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(748, 163);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(62, 29);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(748, 114);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(99, 29);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender:";
            // 
            // lblPatientID
            // 
            lblPatientID.AutoSize = true;
            lblPatientID.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientID.Location = new Point(107, 163);
            lblPatientID.Name = "lblPatientID";
            lblPatientID.Size = new Size(124, 29);
            lblPatientID.TabIndex = 2;
            lblPatientID.Text = "Patient ID:";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPatientName.Location = new Point(107, 114);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(84, 29);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 42);
            label1.Name = "label1";
            label1.Size = new Size(214, 36);
            label1.TabIndex = 0;
            label1.Text = "Patient Details";
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(1233, 940);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(255, 45);
            btnPayment.TabIndex = 100;
            btnPayment.Text = "Proceed to Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(972, 940);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(255, 45);
            btnPrint.TabIndex = 101;
            btnPrint.Text = "Print Billing ";
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
            // Billing
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(btnPrint);
            Controls.Add(btnPayment);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Billing";
            Size = new Size(1520, 1000);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Panel panel2;
        private Label lblPatientName;
        private Label label1;
        private Label label10;
        private Label lblAge;
        private Label lblGender;
        private Label lblPatientID;
        private Button btnPayment;
        private Button btnPrint;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
