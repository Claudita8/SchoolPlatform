using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace SchoolPlatform.Forms
{
    public partial class Students : Form
    {
         int Key ;
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
          Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTeacher_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\WorkspaceApp\SchoolPlatform\SchoolDb.mdf;Integrated Security=True");
     
       private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda); 
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(StNameTb.Text == "" || TaxesTb.Text =="" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName, StGen, StDate, StClass, StTaxes, StAdd) values (@Sname, @SGen,@SDate,@SClass, @STaxes, @SAdd)", Con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDate", DatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.Text);
                    cmd.Parameters.AddWithValue("@STaxes", TaxesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }
        private void Reset()
        {
            Key = 0;
            StNameTb.Text = "";
            TaxesTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex= 0;
            ClassCb.SelectedIndex= 0;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(Key == 0) 
            {
                MessageBox.Show("Selected Student");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from StudentTbl where StId = @StKey", Con);
                    cmd.Parameters.AddWithValue("@Stkey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                    
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
             
            }
        }



        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || TaxesTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update StudentTbl set StName=@Sname, StGen=@SGen, StDate=@SDate, StClass=@SClass, StTaxes=@STaxes, StAdd=@SAdd where StId=@SID", Con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDate", DatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.Text);
                    cmd.Parameters.AddWithValue("@STaxes", TaxesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@SID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void PreComplete()
        {
           
                Con.Open();

                string sql = @" SELECT * from StudentTbl where StId = @id";

                using (SqlCommand comm = new SqlCommand(sql, Con))
                {
                    comm.Parameters.AddWithValue("@id", Key);

                using (var reader = comm.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Something is very wrong");
                    }
                    int StudentId = reader.GetOrdinal("StId");
                    int StudentName = reader.GetOrdinal("StName");
                    int StudentGender = reader.GetOrdinal("StGen");
                    int StudentDate = reader.GetOrdinal("StDate");
                    int StudentClass = reader.GetOrdinal("StClass");
                    int StudentTaxes = reader.GetOrdinal("StTaxes");
                    int StudentAddress = reader.GetOrdinal("StAdd");


                    Key = 0;
                    StNameTb.Text = reader.GetString(StudentName);
                    StGenCb.SelectedIndex = StGenCb.FindString(reader.GetString(StudentGender));

                    DateTime date = reader.GetDateTime(StudentDate);

                    DatePicker.Value = date;

                    ClassCb.SelectedIndex = ClassCb.FindString(reader.GetString(StudentClass));
                    TaxesTb.Text = reader.GetInt32(StudentTaxes).ToString();

                    AddressTb.Text = reader.GetString(StudentAddress);


                }
            }
            Con.Close();
            

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Meniu form = new Meniu();
            form.Show();
            this.Hide();   
        }

        private void StudentsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            StNameTb.Text = StudentsDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            StGenCb.SelectedItem = StudentsDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            DatePicker.Text = StudentsDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            ClassCb.SelectedItem = StudentsDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            TaxesTb.Text = StudentsDGV.Rows[e.RowIndex].Cells[5].Value.ToString();
            AddressTb.Text = StudentsDGV.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
