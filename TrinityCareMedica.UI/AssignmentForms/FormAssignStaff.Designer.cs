namespace TrinityCareMedica.UI
{
    partial class FormAssignStaff
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
            buttonSave = new Button();
            buttonCancel = new Button();
            cbNurse3 = new ComboBox();
            cbNurse2 = new ComboBox();
            cbNurse1 = new ComboBox();
            label3 = new Label();
            cbDoctor3 = new ComboBox();
            cbDoctor2 = new ComboBox();
            cbDoctor1 = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(cbNurse3);
            panel1.Controls.Add(cbNurse2);
            panel1.Controls.Add(cbNurse1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbDoctor3);
            panel1.Controls.Add(cbDoctor2);
            panel1.Controls.Add(cbDoctor1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(651, 388);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(132, 49);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(513, 388);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(132, 49);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // cbNurse3
            // 
            cbNurse3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNurse3.FlatStyle = FlatStyle.System;
            cbNurse3.FormattingEnabled = true;
            cbNurse3.Location = new Point(414, 250);
            cbNurse3.Name = "cbNurse3";
            cbNurse3.Size = new Size(332, 37);
            cbNurse3.Sorted = true;
            cbNurse3.TabIndex = 8;
            cbNurse3.SelectedIndexChanged += cbSelectedIndexChanged;
            // 
            // cbNurse2
            // 
            cbNurse2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNurse2.FlatStyle = FlatStyle.System;
            cbNurse2.FormattingEnabled = true;
            cbNurse2.Location = new Point(414, 207);
            cbNurse2.Name = "cbNurse2";
            cbNurse2.Size = new Size(332, 37);
            cbNurse2.Sorted = true;
            cbNurse2.TabIndex = 7;
            cbNurse2.SelectedIndexChanged += cbSelectedIndexChanged;
            // 
            // cbNurse1
            // 
            cbNurse1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNurse1.FlatStyle = FlatStyle.System;
            cbNurse1.FormattingEnabled = true;
            cbNurse1.Location = new Point(414, 164);
            cbNurse1.Name = "cbNurse1";
            cbNurse1.Size = new Size(332, 37);
            cbNurse1.Sorted = true;
            cbNurse1.TabIndex = 6;
            cbNurse1.SelectedIndexChanged += cbSelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(414, 131);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 5;
            label3.Text = "Nurses:";
            // 
            // cbDoctor3
            // 
            cbDoctor3.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor3.FlatStyle = FlatStyle.System;
            cbDoctor3.FormattingEnabled = true;
            cbDoctor3.Location = new Point(11, 250);
            cbDoctor3.Name = "cbDoctor3";
            cbDoctor3.Size = new Size(332, 37);
            cbDoctor3.Sorted = true;
            cbDoctor3.TabIndex = 4;
            cbDoctor3.SelectedIndexChanged += cbSelectedIndexChanged;
            // 
            // cbDoctor2
            // 
            cbDoctor2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor2.FlatStyle = FlatStyle.System;
            cbDoctor2.FormattingEnabled = true;
            cbDoctor2.Location = new Point(11, 207);
            cbDoctor2.Name = "cbDoctor2";
            cbDoctor2.Size = new Size(332, 37);
            cbDoctor2.Sorted = true;
            cbDoctor2.TabIndex = 3;
            cbDoctor2.SelectedIndexChanged += cbSelectedIndexChanged;
            // 
            // cbDoctor1
            // 
            cbDoctor1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoctor1.FlatStyle = FlatStyle.System;
            cbDoctor1.FormattingEnabled = true;
            cbDoctor1.Location = new Point(11, 164);
            cbDoctor1.Name = "cbDoctor1";
            cbDoctor1.Size = new Size(332, 37);
            cbDoctor1.Sorted = true;
            cbDoctor1.TabIndex = 2;
            cbDoctor1.SelectedIndexChanged += cbSelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(11, 131);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 1;
            label2.Text = "Doctors:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 62);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 1;
            label1.Text = "Assign Staff";
            // 
            // FormAssignStaff
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            CancelButton = buttonCancel;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAssignStaff";
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private ComboBox cbNurse3;
        private ComboBox cbNurse2;
        private ComboBox cbNurse1;
        private Label label3;
        private ComboBox cbDoctor3;
        private ComboBox cbDoctor2;
        private ComboBox cbDoctor1;
        private Button buttonSave;
        private Button buttonCancel;
    }
}