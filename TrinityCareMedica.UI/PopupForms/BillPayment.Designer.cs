namespace TrinityCareMedica.UI.UserControls
{
    partial class BillPayment
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
            label1 = new Label();
            txtBalance = new TextBox();
            label2 = new Label();
            txtPayment = new TextBox();
            btnPay = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 90);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 0;
            label1.Text = "Amount Payable:";
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Microsoft JhengHei UI", 14F);
            txtBalance.Location = new Point(28, 123);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(254, 37);
            txtBalance.TabIndex = 1;
            txtBalance.Enter += txtBalance_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(310, 90);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 3;
            label2.Text = "Payment:";
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Microsoft JhengHei UI", 14F);
            txtPayment.Location = new Point(310, 123);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(254, 37);
            txtPayment.TabIndex = 4;
            txtPayment.KeyPress += txtPayment_KeyPress;
            // 
            // btnPay
            // 
            btnPay.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            btnPay.Location = new Point(481, 205);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(110, 38);
            btnPay.TabIndex = 7;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            btnCancel.Location = new Point(346, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtBalance);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPayment);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 255);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(603, 60);
            panel2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 14F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 15);
            label4.Name = "label4";
            label4.Size = new Size(151, 30);
            label4.TabIndex = 0;
            label4.Text = "Bill Payment";
            // 
            // BillPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(603, 255);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BillPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtBalance;
        private Label label2;
        private TextBox txtPayment;
        private Button btnPay;
        private Button btnCancel;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
    }
}