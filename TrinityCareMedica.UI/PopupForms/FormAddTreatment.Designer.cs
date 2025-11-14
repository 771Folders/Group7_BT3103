namespace TrinityCareMedica.UI.AssignmentForms
{
    partial class FormAddTreatment
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
            txtPrice = new TextBox();
            label8 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            txtTreatment = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(txtTreatment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 327);
            panel1.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(28, 202);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(179, 37);
            txtPrice.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(28, 169);
            label8.Name = "label8";
            label8.Size = new Size(74, 30);
            label8.TabIndex = 15;
            label8.Text = "Price:";
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.WindowText;
            btnAdd.Location = new Point(427, 274);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 42);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.ForeColor = SystemColors.WindowText;
            btnCancel.Location = new Point(297, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 42);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTreatment
            // 
            txtTreatment.Location = new Point(28, 109);
            txtTreatment.Name = "txtTreatment";
            txtTreatment.PlaceholderText = "e.g. Blood Pressure Monitoring";
            txtTreatment.Size = new Size(362, 37);
            txtTreatment.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 76);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 3;
            label1.Text = "Treatment";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(558, 60);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(184, 30);
            label3.TabIndex = 0;
            label3.Text = "Add Treatment";
            // 
            // FormAddTreatment
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(560, 327);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAddTreatment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddTreatment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtTreatment;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox txtPrice;
        private Label label8;
    }
}