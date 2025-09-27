namespace EventDriven.Project.UI
{
    partial class FormLogin
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblFname = new Label();
            btnCancel = new Button();
            label1 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(0, 69, 69, 69);
            lblPassword.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(3, 208);
            lblPassword.Margin = new Padding(3, 10, 3, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(164, 46);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 24F);
            txtPassword.Location = new Point(3, 258);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(489, 61);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 24F);
            txtUsername.Location = new Point(3, 133);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(489, 61);
            txtUsername.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(3, 4);
            btnLogin.Margin = new Padding(3, 4, 35, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(239, 59);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblFname
            // 
            lblFname.AutoSize = true;
            lblFname.BackColor = Color.FromArgb(0, 69, 69, 69);
            lblFname.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFname.ForeColor = Color.White;
            lblFname.Location = new Point(3, 83);
            lblFname.Margin = new Padding(3, 20, 3, 0);
            lblFname.Name = "lblFname";
            lblFname.Size = new Size(171, 46);
            lblFname.TabIndex = 2;
            lblFname.Text = "Username";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Right;
            btnCancel.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(280, 4);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(209, 59);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Exit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 69, 69, 69);
            label1.Font = new Font("Palatino Linotype", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(468, 63);
            label1.TabIndex = 17;
            label1.Text = "Log-in your Account";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(128, 69, 69, 69);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(1254, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 856);
            panel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(lblFname);
            flowLayoutPanel1.Controls.Add(txtUsername);
            flowLayoutPanel1.Controls.Add(lblPassword);
            flowLayoutPanel1.Controls.Add(txtPassword);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(60, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(523, 431);
            flowLayoutPanel1.TabIndex = 18;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnLogin);
            flowLayoutPanel2.Controls.Add(btnCancel);
            flowLayoutPanel2.Location = new Point(3, 353);
            flowLayoutPanel2.Margin = new Padding(3, 30, 3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(517, 75);
            flowLayoutPanel2.TabIndex = 17;
            flowLayoutPanel2.WrapContents = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginBG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1920, 1080);
            ControlBox = false;
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Label lblFname;
        private Button btnCancel;
        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}