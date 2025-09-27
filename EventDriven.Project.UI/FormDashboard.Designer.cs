namespace EventDriven.Project.UI
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new TableLayoutPanel();
            customPanel1 = new CustomControls.CustomPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1920, 60);
            label1.TabIndex = 0;
            label1.Text = "TrinityCare Medica";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(12, 42);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(368, 587);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold);
            button1.Image = Properties.Resources._1000065903;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(364, 121);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Microsoft JhengHei UI", 14F);
            button3.Image = Properties.Resources._1000065901;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 130);
            button3.Name = "button3";
            button3.Size = new Size(364, 121);
            button3.TabIndex = 2;
            button3.Text = "Patient Information\r\nMaintenance";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Microsoft JhengHei UI", 14F);
            button2.Image = Properties.Resources._1000065902;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 257);
            button2.Name = "button2";
            button2.Size = new Size(364, 121);
            button2.TabIndex = 1;
            button2.Text = "Admission";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Microsoft JhengHei UI", 14F);
            button4.Image = Properties.Resources._1000065900;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 384);
            button4.Name = "button4";
            button4.Size = new Size(364, 121);
            button4.TabIndex = 3;
            button4.Text = "     Treatment/ Billing Breakdown";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Font = new Font("Microsoft JhengHei UI", 14F);
            button5.Location = new Point(112, 924);
            button5.Name = "button5";
            button5.Size = new Size(146, 46);
            button5.TabIndex = 4;
            button5.Text = "Logout";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(663, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(663, 410);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(663, 410);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(663, 410);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft JhengHei UI", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(663, 49);
            label2.TabIndex = 6;
            label2.Text = "Doctor/s";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 338);
            label3.Name = "label3";
            label3.Size = new Size(663, 72);
            label3.TabIndex = 7;
            label3.Text = "8\r\nTotal";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft JhengHei UI", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(663, 49);
            label4.TabIndex = 8;
            label4.Text = "Nurse/s";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 338);
            label5.Name = "label5";
            label5.Size = new Size(663, 72);
            label5.TabIndex = 9;
            label5.Text = "8\r\nTotal";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Microsoft JhengHei UI", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(663, 49);
            label6.TabIndex = 10;
            label6.Text = "Patient/s";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Dock = DockStyle.Bottom;
            label7.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 338);
            label7.Name = "label7";
            label7.Size = new Size(663, 72);
            label7.TabIndex = 11;
            label7.Text = "50\r\nAdmitted";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Microsoft JhengHei UI", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(663, 49);
            label8.TabIndex = 12;
            label8.Text = "Room Management";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Dock = DockStyle.Bottom;
            label9.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(0, 338);
            label9.Name = "label9";
            label9.Size = new Size(663, 72);
            label9.TabIndex = 13;
            label9.Text = "94\r\nAvailable";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoSize = true;
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(50, 50);
            panel3.Margin = new Padding(50);
            panel3.Name = "panel3";
            panel3.Size = new Size(663, 410);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(50, 560);
            panel4.Margin = new Padding(50);
            panel4.Name = "panel4";
            panel4.Size = new Size(663, 410);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(813, 560);
            panel5.Margin = new Padding(50);
            panel5.Name = "panel5";
            panel5.Size = new Size(663, 410);
            panel5.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(pictureBox2);
            panel6.Location = new Point(813, 50);
            panel6.Margin = new Padding(50);
            panel6.Name = "panel6";
            panel6.Size = new Size(663, 410);
            panel6.TabIndex = 16;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSeaGreen;
            panel7.ColumnCount = 2;
            panel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panel7.Controls.Add(panel5, 1, 1);
            panel7.Controls.Add(panel4, 0, 1);
            panel7.Controls.Add(panel3, 0, 0);
            panel7.Controls.Add(panel6, 1, 0);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(394, 60);
            panel7.Name = "panel7";
            panel7.RowCount = 2;
            panel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            panel7.Size = new Size(1526, 1020);
            panel7.TabIndex = 17;
            // 
            // customPanel1
            // 
            customPanel1.BorderColor = Color.Black;
            customPanel1.BorderRadius = 0;
            customPanel1.BorderThickness = 0;
            customPanel1.ColorBottom = Color.MediumTurquoise;
            customPanel1.ColorTop = Color.White;
            customPanel1.Controls.Add(button5);
            customPanel1.Controls.Add(flowLayoutPanel1);
            customPanel1.Dock = DockStyle.Left;
            customPanel1.Font = new Font("Microsoft JhengHei UI", 9F);
            customPanel1.Location = new Point(0, 60);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(394, 1020);
            customPanel1.TabIndex = 2;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(panel7);
            Controls.Add(customPanel1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            WindowState = FormWindowState.Maximized;
            Load += FormDashboard_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private TableLayoutPanel panel7;
        private CustomControls.CustomPanel customPanel1;
    }
}