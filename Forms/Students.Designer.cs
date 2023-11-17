namespace SchoolPlatform.Forms
{
    partial class Students
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
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.StGenCb = new System.Windows.Forms.ComboBox();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.ClassCb = new System.Windows.Forms.ComboBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.studentsList = new System.Windows.Forms.Label();
            this.fees = new System.Windows.Forms.Label();
            this.TaxesTb = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Date:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(23, 109);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 53;
            this.name.Text = "Name:";
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.DatePicker.Location = new System.Drawing.Point(331, 135);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(241, 26);
            this.DatePicker.TabIndex = 52;
            // 
            // StGenCb
            // 
            this.StGenCb.FormattingEnabled = true;
            this.StGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StGenCb.Location = new System.Drawing.Point(201, 133);
            this.StGenCb.Name = "StGenCb";
            this.StGenCb.Size = new System.Drawing.Size(99, 28);
            this.StGenCb.TabIndex = 51;
            this.StGenCb.Text = "Gender";
            // 
            // StNameTb
            // 
            this.StNameTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StNameTb.ForeColor = System.Drawing.Color.Red;
            this.StNameTb.Location = new System.Drawing.Point(22, 133);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(158, 36);
            this.StNameTb.TabIndex = 50;
            // 
            // ClassCb
            // 
            this.ClassCb.FormattingEnabled = true;
            this.ClassCb.Items.AddRange(new object[] {
            "8Th",
            "9Th",
            "10Th",
            "11Th"});
            this.ClassCb.Location = new System.Drawing.Point(593, 133);
            this.ClassCb.Name = "ClassCb";
            this.ClassCb.Size = new System.Drawing.Size(99, 28);
            this.ClassCb.TabIndex = 55;
            this.ClassCb.Text = "Class";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.EditBtn.Location = new System.Drawing.Point(547, 228);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(227, 48);
            this.EditBtn.TabIndex = 61;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(300, 228);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(227, 48);
            this.DeleteBtn.TabIndex = 60;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Pink;
            this.SaveBtn.Location = new System.Drawing.Point(43, 228);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(227, 48);
            this.SaveBtn.TabIndex = 59;
            this.SaveBtn.Text = "Add";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Yellow;
            this.BackBtn.Location = new System.Drawing.Point(797, 228);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(227, 48);
            this.BackBtn.TabIndex = 62;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.BackgroundColor = System.Drawing.Color.Linen;
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.Location = new System.Drawing.Point(27, 341);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.RowHeadersWidth = 62;
            this.StudentsDGV.RowTemplate.Height = 28;
            this.StudentsDGV.Size = new System.Drawing.Size(1078, 232);
            this.StudentsDGV.TabIndex = 63;
            this.StudentsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentsDGV_RowHeaderMouseClick);
            // 
            // studentsList
            // 
            this.studentsList.AutoSize = true;
            this.studentsList.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsList.Location = new System.Drawing.Point(486, 307);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(194, 31);
            this.studentsList.TabIndex = 64;
            this.studentsList.Text = "Students List:";
            // 
            // fees
            // 
            this.fees.AutoSize = true;
            this.fees.Location = new System.Drawing.Point(718, 101);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(55, 20);
            this.fees.TabIndex = 66;
            this.fees.Text = "Taxes:";
            // 
            // TaxesTb
            // 
            this.TaxesTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxesTb.ForeColor = System.Drawing.Color.Red;
            this.TaxesTb.Location = new System.Drawing.Point(717, 125);
            this.TaxesTb.Name = "TaxesTb";
            this.TaxesTb.Size = new System.Drawing.Size(158, 36);
            this.TaxesTb.TabIndex = 65;
            this.TaxesTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exit
            // 
            this.exit.Image = global::SchoolPlatform.Properties.Resources.Screenshot_2022_12_27_221032;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(1087, -2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 67;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 76);
            this.panel1.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Students";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(894, 106);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(72, 20);
            this.address.TabIndex = 84;
            this.address.Text = "Address:";
            // 
            // AddressTb
            // 
            this.AddressTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTb.ForeColor = System.Drawing.Color.Red;
            this.AddressTb.Location = new System.Drawing.Point(898, 125);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(158, 84);
            this.AddressTb.TabIndex = 83;
            this.AddressTb.TextChanged += new System.EventHandler(this.addressTeacher_TextChanged);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 585);
            this.Controls.Add(this.address);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.TaxesTb);
            this.Controls.Add(this.studentsList);
            this.Controls.Add(this.StudentsDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ClassCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.StGenCb);
            this.Controls.Add(this.StNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox StGenCb;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.ComboBox ClassCb;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Label studentsList;
        private System.Windows.Forms.Label fees;
        private System.Windows.Forms.TextBox TaxesTb;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox AddressTb;
    }
}