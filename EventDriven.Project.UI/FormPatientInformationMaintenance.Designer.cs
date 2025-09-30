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
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            customPanel1 = new CustomControls.CustomPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            refreshBtn = new Button();
            label2 = new Label();
            searchBtn = new Button();
            txtSearch = new TextBox();
            deleteBtn = new Button();
            editBtn = new Button();
            addBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            customPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button1.BackColor = Color.Transparent;
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
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.White;
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
            button3.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(editBtn);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(394, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1526, 1020);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(refreshBtn);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(searchBtn);
            panel3.Controls.Add(txtSearch);
            panel3.Location = new Point(47, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(1415, 58);
            panel3.TabIndex = 4;
            // 
            // refreshBtn
            // 
            refreshBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            refreshBtn.BackgroundImage = Properties.Resources.refresh;
            refreshBtn.BackgroundImageLayout = ImageLayout.Zoom;
            refreshBtn.Location = new Point(891, 9);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(40, 40);
            refreshBtn.TabIndex = 3;
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(444, 35);
            label2.TabIndex = 2;
            label2.Text = "Patient Information Maintenance";
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            searchBtn.Font = new Font("Microsoft JhengHei UI", 14F);
            searchBtn.Location = new Point(1274, 11);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(125, 37);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtSearch.Font = new Font("Microsoft JhengHei UI", 14F);
            txtSearch.Location = new Point(943, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(325, 37);
            txtSearch.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Microsoft JhengHei UI", 14F);
            deleteBtn.Location = new Point(1279, 896);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(183, 60);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Microsoft JhengHei UI", 14F);
            editBtn.Location = new Point(1090, 896);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(183, 60);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Microsoft JhengHei UI", 14F);
            addBtn.Location = new Point(901, 896);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(183, 60);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1415, 748);
            dataGridView1.TabIndex = 0;
            // 
            // FormPatientInformationMaintenance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(customPanel1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPatientInformationMaintenance";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormPatientInformationMaintenance_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.CustomPanel customPanel1;
        private Panel panel2;
        private Button deleteBtn;
        private Button editBtn;
        private Button addBtn;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button searchBtn;
        private TextBox txtSearch;
        private Label label2;
        private Button refreshBtn;
    }
}