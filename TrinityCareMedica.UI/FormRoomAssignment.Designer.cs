namespace TrinityCareMedica.UI
{
    partial class FormRoomAssignment
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
            cbBedNo = new ComboBox();
            label4 = new Label();
            buttonCancel = new Button();
            buttonAssign = new Button();
            dateEndDate = new DateTimePicker();
            label3 = new Label();
            dateStartDate = new DateTimePicker();
            label2 = new Label();
            cbRoomNo = new ComboBox();
            label1 = new Label();
            cbRoomType = new ComboBox();
            labelRoom = new Label();
            labelPatientID = new Label();
            labelName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cbBedNo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonAssign);
            panel1.Controls.Add(dateEndDate);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateStartDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbRoomNo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbRoomType);
            panel1.Controls.Add(labelRoom);
            panel1.Controls.Add(labelPatientID);
            panel1.Controls.Add(labelName);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Microsoft JhengHei UI", 14F);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 403);
            panel1.TabIndex = 0;
            // 
            // cbBedNo
            // 
            cbBedNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBedNo.FormattingEnabled = true;
            cbBedNo.Location = new Point(206, 217);
            cbBedNo.Name = "cbBedNo";
            cbBedNo.Size = new Size(215, 37);
            cbBedNo.TabIndex = 15;
            cbBedNo.SelectedIndexChanged += cbBedNo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 220);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 14;
            label4.Text = "Bed Number:";
            // 
            // buttonCancel
            // 
            buttonCancel.ForeColor = SystemColors.ControlText;
            buttonCancel.Location = new Point(500, 353);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(132, 38);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAssign
            // 
            buttonAssign.ForeColor = SystemColors.ControlText;
            buttonAssign.Location = new Point(638, 353);
            buttonAssign.Name = "buttonAssign";
            buttonAssign.Size = new Size(132, 38);
            buttonAssign.TabIndex = 12;
            buttonAssign.Text = "Transfer";
            buttonAssign.UseVisualStyleBackColor = true;
            buttonAssign.Click += buttonAssign_Click;
            // 
            // dateEndDate
            // 
            dateEndDate.Checked = false;
            dateEndDate.CustomFormat = " ";
            dateEndDate.Font = new Font("Microsoft JhengHei UI", 14F);
            dateEndDate.Format = DateTimePickerFormat.Custom;
            dateEndDate.Location = new Point(572, 167);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.ShowCheckBox = true;
            dateEndDate.Size = new Size(198, 37);
            dateEndDate.TabIndex = 11;
            dateEndDate.ValueChanged += dateEndDate_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 170);
            label3.Name = "label3";
            label3.Size = new Size(122, 30);
            label3.TabIndex = 10;
            label3.Text = "End Date:";
            // 
            // dateStartDate
            // 
            dateStartDate.Font = new Font("Microsoft JhengHei UI", 14F);
            dateStartDate.Format = DateTimePickerFormat.Short;
            dateStartDate.Location = new Point(572, 117);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(198, 37);
            dateStartDate.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 120);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 8;
            label2.Text = "Start Date:";
            // 
            // cbRoomNo
            // 
            cbRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomNo.FormattingEnabled = true;
            cbRoomNo.Location = new Point(206, 167);
            cbRoomNo.Name = "cbRoomNo";
            cbRoomNo.Size = new Size(215, 37);
            cbRoomNo.TabIndex = 7;
            cbRoomNo.SelectedIndexChanged += cbRoomNo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 170);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 6;
            label1.Text = "Room Number:";
            // 
            // cbRoomType
            // 
            cbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(166, 117);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(255, 37);
            cbRoomType.TabIndex = 5;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(14, 120);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(146, 30);
            labelRoom.TabIndex = 4;
            labelRoom.Text = "Room Type:";
            // 
            // labelPatientID
            // 
            labelPatientID.AutoSize = true;
            labelPatientID.Font = new Font("Microsoft JhengHei UI", 14F);
            labelPatientID.Location = new Point(14, 20);
            labelPatientID.Margin = new Padding(5, 0, 5, 0);
            labelPatientID.Name = "labelPatientID";
            labelPatientID.Size = new Size(130, 30);
            labelPatientID.TabIndex = 2;
            labelPatientID.Text = "Patient ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft JhengHei UI", 14F);
            labelName.Location = new Point(14, 70);
            labelName.Name = "labelName";
            labelName.Size = new Size(87, 30);
            labelName.TabIndex = 3;
            labelName.Text = "Name:";
            // 
            // FormRoomAssignment
            // 
            AcceptButton = buttonAssign;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            CancelButton = buttonCancel;
            ClientSize = new Size(782, 403);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FormRoomAssignment";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRoomAssignment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelPatientID;
        private Label labelName;
        private Label labelRoom;
        private ComboBox cbRoomNo;
        private Label label1;
        private ComboBox cbRoomType;
        private DateTimePicker dateStartDate;
        private Label label2;
        private DateTimePicker dateEndDate;
        private Label label3;
        private Button buttonCancel;
        private Button buttonAssign;
        private ComboBox cbBedNo;
        private Label label4;
    }
}