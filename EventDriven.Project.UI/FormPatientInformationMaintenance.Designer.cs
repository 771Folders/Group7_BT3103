namespace EventDriven.Project.UI
{
    partial class FormPatientInformationMaintenance
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
            button5 = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Sex = new DataGridViewTextBoxColumn();
            Diagnosis = new DataGridViewTextBoxColumn();
            Admitted = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(126, 864);
            button5.Name = "button5";
            button5.Size = new Size(147, 46);
            button5.TabIndex = 4;
            button5.Text = "LogOut";
            button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(button5);
            panel2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(-3, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 922);
            panel2.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(21, 107);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(350, 587);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources._1000065903;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(347, 112);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources._1000065902;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 121);
            button2.Name = "button2";
            button2.Size = new Size(347, 112);
            button2.TabIndex = 1;
            button2.Text = "Admission";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources._1000065901;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 239);
            button3.Name = "button3";
            button3.Size = new Size(347, 112);
            button3.TabIndex = 2;
            button3.Text = "Patient Information\r\nMaintenance";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft JhengHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = Properties.Resources._1000065900;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 357);
            button4.Name = "button4";
            button4.Size = new Size(347, 112);
            button4.TabIndex = 3;
            button4.Text = "Treatment/ Billing Breakdown";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1909, 114);
            panel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(668, 17);
            label2.Name = "label2";
            label2.Size = new Size(573, 81);
            label2.TabIndex = 2;
            label2.Text = "TrinityCare Medica";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Room, Age, Sex, Diagnosis, Admitted });
            dataGridView1.Location = new Point(445, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1417, 811);
            dataGridView1.TabIndex = 16;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Room
            // 
            Room.HeaderText = "Room";
            Room.MinimumWidth = 6;
            Room.Name = "Room";
            Room.Width = 125;
            // 
            // Age
            // 
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.Width = 125;
            // 
            // Sex
            // 
            Sex.HeaderText = "Sex";
            Sex.MinimumWidth = 6;
            Sex.Name = "Sex";
            Sex.Width = 125;
            // 
            // Diagnosis
            // 
            Diagnosis.HeaderText = "Diagnosis";
            Diagnosis.MinimumWidth = 6;
            Diagnosis.Name = "Diagnosis";
            Diagnosis.Width = 125;
            // 
            // Admitted
            // 
            Admitted.HeaderText = "Admitted";
            Admitted.MinimumWidth = 6;
            Admitted.Name = "Admitted";
            Admitted.Width = 125;
            // 
            // FormPatientInformationMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPatients.cs";
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Panel panel2;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Room;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn Diagnosis;
        private DataGridViewTextBoxColumn Admitted;
    }
}