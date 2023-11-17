namespace SchoolPlatform.Forms
{
    partial class Attendance
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
            this.attendanceList = new System.Windows.Forms.Label();
            this.AttendanceDGV = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AttStatusCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameStudent = new System.Windows.Forms.Label();
            this.AttDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StIdCb = new System.Windows.Forms.ComboBox();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStud = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attendanceList
            // 
            this.attendanceList.AutoSize = true;
            this.attendanceList.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendanceList.Location = new System.Drawing.Point(428, 335);
            this.attendanceList.Name = "attendanceList";
            this.attendanceList.Size = new System.Drawing.Size(222, 31);
            this.attendanceList.TabIndex = 70;
            this.attendanceList.Text = "Attendance List:";
            // 
            // AttendanceDGV
            // 
            this.AttendanceDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.AttendanceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceDGV.Location = new System.Drawing.Point(21, 369);
            this.AttendanceDGV.Name = "AttendanceDGV";
            this.AttendanceDGV.RowHeadersWidth = 62;
            this.AttendanceDGV.RowTemplate.Height = 28;
            this.AttendanceDGV.Size = new System.Drawing.Size(1008, 186);
            this.AttendanceDGV.TabIndex = 69;
            this.AttendanceDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AttendanceDGV_RowHeaderMouseClick);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Yellow;
            this.BackBtn.Location = new System.Drawing.Point(807, 242);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(170, 36);
            this.BackBtn.TabIndex = 68;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.EditBtn.Location = new System.Drawing.Point(557, 242);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(170, 36);
            this.EditBtn.TabIndex = 67;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(310, 242);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(170, 36);
            this.DeleteBtn.TabIndex = 66;
            this.DeleteBtn.Text = "Reset";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Pink;
            this.AddBtn.Location = new System.Drawing.Point(53, 242);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(170, 36);
            this.AddBtn.TabIndex = 65;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.add_Click);
            // 
            // AttStatusCb
            // 
            this.AttStatusCb.FormattingEnabled = true;
            this.AttStatusCb.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.AttStatusCb.Location = new System.Drawing.Point(807, 154);
            this.AttStatusCb.Name = "AttStatusCb";
            this.AttStatusCb.Size = new System.Drawing.Size(192, 28);
            this.AttStatusCb.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Date:";
            // 
            // nameStudent
            // 
            this.nameStudent.AutoSize = true;
            this.nameStudent.Location = new System.Drawing.Point(252, 120);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(116, 20);
            this.nameStudent.TabIndex = 74;
            this.nameStudent.Text = "Student Name:";
            // 
            // AttDatePicker
            // 
            this.AttDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.AttDatePicker.Location = new System.Drawing.Point(445, 152);
            this.AttDatePicker.Name = "AttDatePicker";
            this.AttDatePicker.Size = new System.Drawing.Size(314, 26);
            this.AttDatePicker.TabIndex = 73;
            // 
            // StIdCb
            // 
            this.StIdCb.FormattingEnabled = true;
            this.StIdCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StIdCb.Location = new System.Drawing.Point(43, 152);
            this.StIdCb.Name = "StIdCb";
            this.StIdCb.Size = new System.Drawing.Size(175, 28);
            this.StIdCb.TabIndex = 72;
            this.StIdCb.SelectionChangeCommitted += new System.EventHandler(this.StIdCb_SelectionChangeCommitted);
            // 
            // StNameTb
            // 
            this.StNameTb.Enabled = false;
            this.StNameTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StNameTb.ForeColor = System.Drawing.Color.Red;
            this.StNameTb.Location = new System.Drawing.Point(251, 144);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(158, 36);
            this.StNameTb.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Student ID:";
            // 
            // statusStud
            // 
            this.statusStud.AutoSize = true;
            this.statusStud.Location = new System.Drawing.Point(803, 129);
            this.statusStud.Name = "statusStud";
            this.statusStud.Size = new System.Drawing.Size(60, 20);
            this.statusStud.TabIndex = 78;
            this.statusStud.Text = "Status:";
            // 
            // exit
            // 
            this.exit.Image = global::SchoolPlatform.Properties.Resources.Screenshot_2022_12_27_221032;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(1007, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 79;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(43, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 76);
            this.panel1.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Attendance";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.statusStud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttStatusCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameStudent);
            this.Controls.Add(this.AttDatePicker);
            this.Controls.Add(this.StIdCb);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.attendanceList);
            this.Controls.Add(this.AttendanceDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label attendanceList;
        private System.Windows.Forms.DataGridView AttendanceDGV;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox AttStatusCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameStudent;
        private System.Windows.Forms.DateTimePicker AttDatePicker;
        private System.Windows.Forms.ComboBox StIdCb;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusStud;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}