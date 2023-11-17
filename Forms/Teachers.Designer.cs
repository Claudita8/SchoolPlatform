namespace SchoolPlatform.Forms
{
    partial class Teachers
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
            this.address = new System.Windows.Forms.Label();
            this.TAddTb = new System.Windows.Forms.TextBox();
            this.teachersList = new System.Windows.Forms.Label();
            this.TeachersDGV = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.TDate = new System.Windows.Forms.DateTimePicker();
            this.TGenCb = new System.Windows.Forms.ComboBox();
            this.TnameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TPhoneTb = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(657, 128);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(72, 20);
            this.address.TabIndex = 80;
            this.address.Text = "Address:";
            // 
            // TAddTb
            // 
            this.TAddTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAddTb.ForeColor = System.Drawing.Color.Red;
            this.TAddTb.Location = new System.Drawing.Point(656, 152);
            this.TAddTb.Multiline = true;
            this.TAddTb.Name = "TAddTb";
            this.TAddTb.Size = new System.Drawing.Size(158, 84);
            this.TAddTb.TabIndex = 79;
            // 
            // teachersList
            // 
            this.teachersList.AutoSize = true;
            this.teachersList.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teachersList.Location = new System.Drawing.Point(334, 366);
            this.teachersList.Name = "teachersList";
            this.teachersList.Size = new System.Drawing.Size(186, 31);
            this.teachersList.TabIndex = 78;
            this.teachersList.Text = "Teachers List:";
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersDGV.Location = new System.Drawing.Point(26, 413);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.RowHeadersWidth = 62;
            this.TeachersDGV.RowTemplate.Height = 28;
            this.TeachersDGV.Size = new System.Drawing.Size(967, 232);
            this.TeachersDGV.TabIndex = 77;
            this.TeachersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDGV_CellContentClick_1);
            this.TeachersDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TeachersDGV_RowHeaderMouseClick);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Yellow;
            this.BackBtn.Location = new System.Drawing.Point(710, 299);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(176, 37);
            this.BackBtn.TabIndex = 76;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.EditBtn.Location = new System.Drawing.Point(517, 299);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(176, 37);
            this.EditBtn.TabIndex = 75;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(319, 299);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(176, 37);
            this.DeleteBtn.TabIndex = 74;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Pink;
            this.AddBtn.Location = new System.Drawing.Point(105, 299);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(176, 37);
            this.AddBtn.TabIndex = 73;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // SubCb
            // 
            this.SubCb.FormattingEnabled = true;
            this.SubCb.Items.AddRange(new object[] {
            "Math",
            "Geography",
            "English",
            "Hindi"});
            this.SubCb.Location = new System.Drawing.Point(843, 201);
            this.SubCb.Name = "SubCb";
            this.SubCb.Size = new System.Drawing.Size(99, 28);
            this.SubCb.TabIndex = 72;
            this.SubCb.Text = "Subjects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Date:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(27, 128);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 70;
            this.name.Text = "Name:";
            // 
            // TDate
            // 
            this.TDate.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.TDate.Location = new System.Drawing.Point(360, 231);
            this.TDate.Name = "TDate";
            this.TDate.Size = new System.Drawing.Size(268, 26);
            this.TDate.TabIndex = 69;
            // 
            // TGenCb
            // 
            this.TGenCb.FormattingEnabled = true;
            this.TGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.TGenCb.Location = new System.Drawing.Point(389, 152);
            this.TGenCb.Name = "TGenCb";
            this.TGenCb.Size = new System.Drawing.Size(202, 28);
            this.TGenCb.TabIndex = 68;
            this.TGenCb.Text = "Gender";
            // 
            // TnameTb
            // 
            this.TnameTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TnameTb.ForeColor = System.Drawing.Color.Red;
            this.TnameTb.Location = new System.Drawing.Point(26, 152);
            this.TnameTb.Name = "TnameTb";
            this.TnameTb.Size = new System.Drawing.Size(274, 36);
            this.TnameTb.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Phone:";
            // 
            // TPhoneTb
            // 
            this.TPhoneTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPhoneTb.ForeColor = System.Drawing.Color.Red;
            this.TPhoneTb.Location = new System.Drawing.Point(26, 231);
            this.TPhoneTb.Name = "TPhoneTb";
            this.TPhoneTb.Size = new System.Drawing.Size(246, 36);
            this.TPhoneTb.TabIndex = 81;
            // 
            // exit
            // 
            this.exit.Image = global::SchoolPlatform.Properties.Resources.Screenshot_2022_12_27_221032;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(976, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 83;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 76);
            this.panel1.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teachers";
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPhoneTb);
            this.Controls.Add(this.address);
            this.Controls.Add(this.TAddTb);
            this.Controls.Add(this.teachersList);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.SubCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.TDate);
            this.Controls.Add(this.TGenCb);
            this.Controls.Add(this.TnameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teachers";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.Teachers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox TAddTb;
        private System.Windows.Forms.Label teachersList;
        private System.Windows.Forms.DataGridView TeachersDGV;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ComboBox SubCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker TDate;
        private System.Windows.Forms.ComboBox TGenCb;
        private System.Windows.Forms.TextBox TnameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TPhoneTb;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}