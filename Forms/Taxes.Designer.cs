namespace SchoolPlatform.Forms
{
    partial class Taxes
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
            this.amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.period = new System.Windows.Forms.Label();
            this.nameStudent = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.studentID = new System.Windows.Forms.ComboBox();
            this.nameStud = new System.Windows.Forms.TextBox();
            this.taxesList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(716, 114);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(69, 20);
            this.amount.TabIndex = 92;
            this.amount.Text = "Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Student ID:";
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Present",
            "Absent",
            "Excused"});
            this.status.Location = new System.Drawing.Point(713, 142);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(189, 28);
            this.status.TabIndex = 90;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(441, 123);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(58, 20);
            this.period.TabIndex = 89;
            this.period.Text = "Period:";
            // 
            // nameStudent
            // 
            this.nameStudent.AutoSize = true;
            this.nameStudent.Location = new System.Drawing.Point(243, 114);
            this.nameStudent.Name = "nameStudent";
            this.nameStudent.Size = new System.Drawing.Size(116, 20);
            this.nameStudent.TabIndex = 88;
            this.nameStudent.Text = "Student Name:";
            // 
            // calendar
            // 
            this.calendar.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.calendar.Location = new System.Drawing.Point(436, 146);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(241, 26);
            this.calendar.TabIndex = 87;
            // 
            // studentID
            // 
            this.studentID.FormattingEnabled = true;
            this.studentID.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.studentID.Location = new System.Drawing.Point(34, 146);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(175, 28);
            this.studentID.TabIndex = 86;
            // 
            // nameStud
            // 
            this.nameStud.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStud.ForeColor = System.Drawing.Color.Red;
            this.nameStud.Location = new System.Drawing.Point(242, 138);
            this.nameStud.Name = "nameStud";
            this.nameStud.Size = new System.Drawing.Size(158, 36);
            this.nameStud.TabIndex = 85;
            // 
            // taxesList
            // 
            this.taxesList.AutoSize = true;
            this.taxesList.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxesList.Location = new System.Drawing.Point(404, 295);
            this.taxesList.Name = "taxesList";
            this.taxesList.Size = new System.Drawing.Size(150, 31);
            this.taxesList.TabIndex = 84;
            this.taxesList.Text = "Taxes List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(934, 207);
            this.dataGridView1.TabIndex = 83;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Yellow;
            this.back.Location = new System.Drawing.Point(776, 236);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(170, 36);
            this.back.TabIndex = 82;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.SpringGreen;
            this.edit.Location = new System.Drawing.Point(531, 236);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(170, 36);
            this.edit.TabIndex = 81;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(284, 236);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(170, 36);
            this.delete.TabIndex = 80;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Pink;
            this.add.Location = new System.Drawing.Point(44, 236);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(170, 36);
            this.add.TabIndex = 79;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            this.exit.Image = global::SchoolPlatform.Properties.Resources.Screenshot_2022_12_27_221032;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(932, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 93;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 67);
            this.panel1.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Taxes";
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.period);
            this.Controls.Add(this.nameStudent);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.nameStud);
            this.Controls.Add(this.taxesList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fees";
            this.Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label nameStudent;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.ComboBox studentID;
        private System.Windows.Forms.TextBox nameStud;
        private System.Windows.Forms.Label taxesList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}