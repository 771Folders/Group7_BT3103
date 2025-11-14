namespace TrinityCareMedica.UI.AssignmentForms
{
    partial class FormAssignRoom
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
            buttonSave = new Button();
            buttonCancel = new Button();
            comboBoxRoomType = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBoxRoomNo = new ComboBox();
            label4 = new Label();
            comboBoxBedNo = new ComboBox();
            dateStartDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dateEndDate = new DateTimePicker();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 60);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(161, 30);
            label1.TabIndex = 0;
            label1.Text = "Assign Room";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(657, 239);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(132, 49);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(519, 239);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(132, 49);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(11, 103);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(417, 37);
            comboBoxRoomType.TabIndex = 13;
            comboBoxRoomType.SelectedIndexChanged += comboBoxRoomType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 70);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 14;
            label2.Text = "Room Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(11, 145);
            label3.Name = "label3";
            label3.Size = new Size(186, 30);
            label3.TabIndex = 16;
            label3.Text = "Room Number:";
            // 
            // comboBoxRoomNo
            // 
            comboBoxRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoomNo.Enabled = false;
            comboBoxRoomNo.FormattingEnabled = true;
            comboBoxRoomNo.Location = new Point(11, 178);
            comboBoxRoomNo.Name = "comboBoxRoomNo";
            comboBoxRoomNo.Size = new Size(186, 37);
            comboBoxRoomNo.TabIndex = 15;
            comboBoxRoomNo.SelectedIndexChanged += comboBoxRoomNo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(244, 148);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 18;
            label4.Text = "Bed Number:";
            // 
            // comboBoxBedNo
            // 
            comboBoxBedNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBedNo.Enabled = false;
            comboBoxBedNo.FormattingEnabled = true;
            comboBoxBedNo.Location = new Point(244, 181);
            comboBoxBedNo.Name = "comboBoxBedNo";
            comboBoxBedNo.Size = new Size(184, 37);
            comboBoxBedNo.TabIndex = 17;
            // 
            // dateStartDate
            // 
            dateStartDate.Format = DateTimePickerFormat.Short;
            dateStartDate.Location = new Point(519, 103);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(270, 37);
            dateStartDate.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(519, 70);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 20;
            label5.Text = "Start Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(519, 145);
            label6.Name = "label6";
            label6.Size = new Size(122, 30);
            label6.TabIndex = 22;
            label6.Text = "End Date:";
            // 
            // dateEndDate
            // 
            dateEndDate.Checked = false;
            dateEndDate.CustomFormat = "";
            dateEndDate.Format = DateTimePickerFormat.Short;
            dateEndDate.Location = new Point(519, 178);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.ShowCheckBox = true;
            dateEndDate.Size = new Size(270, 37);
            dateEndDate.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 299);
            panel2.TabIndex = 23;
            // 
            // FormAssignRoom
            // 
            AcceptButton = buttonSave;
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            CancelButton = buttonCancel;
            ClientSize = new Size(800, 300);
            Controls.Add(label6);
            Controls.Add(dateEndDate);
            Controls.Add(label5);
            Controls.Add(dateStartDate);
            Controls.Add(label4);
            Controls.Add(comboBoxBedNo);
            Controls.Add(label3);
            Controls.Add(comboBoxRoomNo);
            Controls.Add(label2);
            Controls.Add(comboBoxRoomType);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(panel2);
            Font = new Font("Microsoft JhengHei UI", 14F);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormAssignRoom";
            StartPosition = FormStartPosition.CenterParent;
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonSave;
        private Button buttonCancel;
        private ComboBox comboBoxRoomType;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxRoomNo;
        private Label label4;
        private ComboBox comboBoxBedNo;
        private DateTimePicker dateStartDate;
        private Label label5;
        private Label label6;
        private DateTimePicker dateEndDate;
        private Panel panel2;
    }
}