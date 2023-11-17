using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolPlatform.Forms
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            DisplayAttendance();
            FillStudId();
        }
        int Key;
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", Con);
            SqlDataReader rdr;
            rdr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            StIdCb.ValueMember = "StId";
            StIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetStudName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentTbl where StId=@SID", Con);
            cmd.Parameters.AddWithValue("@SID", StIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();
            }
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\WorkspaceApp\SchoolPlatform\SchoolDb.mdf;Integrated Security=True");

   

        private void DisplayAttendance()
        {
            Con.Open();
            string Query = "Select * from AttendancesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AttendanceDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
  
        private void Reset()
        {
            AttStatusCb.SelectedIndex = -1;
            StNameTb.Text = "";
            StIdCb.SelectedIndex= -1;
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AttStatusCb.SelectedIndex == -1 )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AttendancesTbl(AttStId, AttStName, AttDate, AttStatus) values" + " (@StId, @StName, @AttDate, @Status)", Con);
                    cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@AttDate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", AttStatusCb.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance received");
                    Con.Close();
                    DisplayAttendance();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void StIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            StIdCb.Text = "";
            StNameTb.Text = "";
            AttDatePicker.Text = "";
            AttStatusCb.Text = "";

            MessageBox.Show("Student reset");
            
        }

        private void AttendanceDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Key = Convert.ToInt32(AttendanceDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            StIdCb.Text = AttendanceDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            StNameTb.Text = AttendanceDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            AttDatePicker.Text = AttendanceDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            AttStatusCb.SelectedItem = AttendanceDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            /*Con.Open();
            SqlCommand cmd = new SqlCommand("Select AttNum From AttendancesTbl where AttStId='"+StNameTb.Text+"'", Con);
            cmd.ExecuteNonQuery();
            DisplayAttendance();
            Reset();
            Con.Close();
        */}

        private void EditBtn_Click(object sender, EventArgs e)
        { 
            
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update AttendancesTbl set AttStId=@StId, AttDate=@ADate, AttStatus=@AStatus where AttNum=@ANum", Con);
                     cmd.Parameters.AddWithValue("@StId", StIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@ADate", AttDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@AStatus", AttStatusCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ANum", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated");
                    Con.Close();
                    DisplayAttendance  ();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
            
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Meniu form = new Meniu();
            form.Show();
            this.Hide();
        }
    }
}
