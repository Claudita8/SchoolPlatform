namespace SchoolPlatform.Forms
{
    partial class Events
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
            this.date = new System.Windows.Forms.Label();
            this.eventsStud = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.eventsTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.durationH = new System.Windows.Forms.TextBox();
            this.eventsList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(362, 155);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(48, 20);
            this.date.TabIndex = 93;
            this.date.Text = "Date:";
            // 
            // eventsStud
            // 
            this.eventsStud.AutoSize = true;
            this.eventsStud.Location = new System.Drawing.Point(63, 152);
            this.eventsStud.Name = "eventsStud";
            this.eventsStud.Size = new System.Drawing.Size(62, 20);
            this.eventsStud.TabIndex = 92;
            this.eventsStud.Text = "Events:";
            // 
            // calendar
            // 
            this.calendar.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.calendar.Location = new System.Drawing.Point(357, 178);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(241, 26);
            this.calendar.TabIndex = 91;
            // 
            // eventsTb
            // 
            this.eventsTb.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsTb.ForeColor = System.Drawing.Color.Red;
            this.eventsTb.Location = new System.Drawing.Point(62, 176);
            this.eventsTb.Name = "eventsTb";
            this.eventsTb.Size = new System.Drawing.Size(271, 36);
            this.eventsTb.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 95;
            this.label1.Text = "Duration in Hours:";
            // 
            // durationH
            // 
            this.durationH.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationH.ForeColor = System.Drawing.Color.Red;
            this.durationH.Location = new System.Drawing.Point(634, 176);
            this.durationH.Name = "durationH";
            this.durationH.Size = new System.Drawing.Size(271, 36);
            this.durationH.TabIndex = 94;
            // 
            // eventsList
            // 
            this.eventsList.AutoSize = true;
            this.eventsList.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsList.Location = new System.Drawing.Point(359, 296);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(164, 31);
            this.eventsList.TabIndex = 101;
            this.eventsList.Text = "Events List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(943, 232);
            this.dataGridView1.TabIndex = 100;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Yellow;
            this.back.Location = new System.Drawing.Point(691, 238);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(118, 37);
            this.back.TabIndex = 99;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.SpringGreen;
            this.edit.Location = new System.Drawing.Point(498, 238);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(118, 37);
            this.edit.TabIndex = 98;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = false;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(300, 238);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 37);
            this.delete.TabIndex = 97;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Pink;
            this.add.Location = new System.Drawing.Point(86, 238);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(118, 37);
            this.add.TabIndex = 96;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(38, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 76);
            this.panel1.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Events";
            // 
            // exit
            // 
            this.exit.Image = global::SchoolPlatform.Properties.Resources.Screenshot_2022_12_27_221032;
            this.exit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit.Location = new System.Drawing.Point(957, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(31, 27);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 103;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 587);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationH);
            this.Controls.Add(this.date);
            this.Controls.Add(this.eventsStud);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.eventsTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Events";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label eventsStud;
        private System.Windows.Forms.DateTimePicker calendar;
        private System.Windows.Forms.TextBox eventsTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox durationH;
        private System.Windows.Forms.Label eventsList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox exit;
    }
}