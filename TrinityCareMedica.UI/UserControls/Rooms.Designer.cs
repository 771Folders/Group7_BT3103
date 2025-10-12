namespace TrinityCareMedica.UI.UserControls
{
    partial class Rooms
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataRooms = new DataGridView();
            panel1 = new Panel();
            labelTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataRooms).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataRooms
            // 
            dataRooms.AllowUserToAddRows = false;
            dataRooms.AllowUserToDeleteRows = false;
            dataRooms.AllowUserToResizeRows = false;
            dataRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataRooms.DefaultCellStyle = dataGridViewCellStyle2;
            dataRooms.EnableHeadersVisualStyles = false;
            dataRooms.Location = new Point(60, 116);
            dataRooms.MultiSelect = false;
            dataRooms.Name = "dataRooms";
            dataRooms.ReadOnly = true;
            dataRooms.RowHeadersVisible = false;
            dataRooms.RowHeadersWidth = 51;
            dataRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataRooms.ShowCellToolTips = false;
            dataRooms.ShowEditingIcon = false;
            dataRooms.Size = new Size(1400, 750);
            dataRooms.TabIndex = 102;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(labelTitle);
            panel1.Location = new Point(60, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(1400, 60);
            panel1.TabIndex = 101;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft JhengHei UI", 22F);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(13, 7);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(141, 47);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Rooms";
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            Controls.Add(dataRooms);
            Controls.Add(panel1);
            Font = new Font("Microsoft JhengHei UI", 14F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Rooms";
            Size = new Size(1520, 1000);
            ((System.ComponentModel.ISupportInitialize)dataRooms).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataRooms;
        private Panel panel1;
        private Label labelTitle;
    }
}
