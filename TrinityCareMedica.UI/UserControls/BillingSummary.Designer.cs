namespace TrinityCareMedica.UI.UserControls
{
    partial class BillingSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingSummary));
            panel1 = new Panel();
            panel2 = new Panel();
            labelTitle = new Label();
            btnPrint = new Button();
            dataSummary = new DataGridView();
            btnExit = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataSummary).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(dataSummary);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1520, 1000);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(labelTitle);
            panel2.Location = new Point(60, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 60);
            panel2.TabIndex = 114;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 22F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(13, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(303, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Billing Summary";
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(1123, 915);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(153, 53);
            btnPrint.TabIndex = 113;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // dataSummary
            // 
            dataSummary.BackgroundColor = Color.White;
            dataSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSummary.Location = new Point(60, 135);
            dataSummary.Name = "dataSummary";
            dataSummary.RowHeadersWidth = 51;
            dataSummary.Size = new Size(1400, 747);
            dataSummary.TabIndex = 112;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1296, 915);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(153, 53);
            btnExit.TabIndex = 111;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
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
            // printDocument1
            // 
            printDocument1.DocumentName = "Receipt";
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // BillingSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(panel1);
            Name = "BillingSummary";
            Size = new Size(1520, 1000);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPrint;
        private DataGridView dataSummary;
        private Button btnExit;
        private Panel panel2;
        private Label labelTitle;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
