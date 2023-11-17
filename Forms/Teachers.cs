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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Desktop\WorkspaceApp\SchoolPlatform\SchoolDb.mdf;Integrated Security=True");

        int Key;

        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            Con.Close();

        }

        private void Teachers_Load(object sender, EventArgs e)
        {
             
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            TnameTb.Text = "";
            SubCb.SelectedIndex = 0;
            TGenCb.SelectedIndex = 0;
            TPhoneTb.Text = "";
            TAddTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl(TName, TGen, TPhone, TSub, TAdd, TDate) values" +
                        " (@TName, @TGen, @TPhone, @TSub, @TAdd, @TDate)", Con);
                    cmd.Parameters.AddWithValue("@TName", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.Text);
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDate", TDate.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Key.ToString());
            if (Key == 0)
            {
                MessageBox.Show("Selected Teacher");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from TeacherTbl where TId = @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted");
                    Con.Close();
                    DisplayTeachers();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update TeacherTbl set TName=@TName, TGen=@TGen, TPhone=@TPhone, TSub=@TSub, TAdd=@TAdd, TDate=@TDate where TId=@TeachId", Con);
                    cmd.Parameters.AddWithValue("@TName", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.Text);
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDate", TDate.Value.Date);
                    cmd.Parameters.AddWithValue("@TeachId", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void TeachersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TeachersDGV.SelectedCells.Count > 0)
            {
                int id = TeachersDGV.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = TeachersDGV.Rows[id];
                Key = Convert.ToInt32(selectedRow.Cells["TId"].Value);

            }
            PreComplete();
        }

        private void PreComplete()
        {

            Con.Open();

            string sql = @" SELECT * from TeacherTbl where TId = @id";

            using (SqlCommand comm = new SqlCommand(sql, Con))
            {
                comm.Parameters.AddWithValue("@id", Key);

                using (var reader = comm.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Something is very wrong");
                    }
                    int TeacherId = reader.GetOrdinal("TId");
                    int TeacherName = reader.GetOrdinal("TName");
                    int TeacherGender = reader.GetOrdinal("TGen");
                    int TeacherDate = reader.GetOrdinal("TDate");
                    int TeacherPhone = reader.GetOrdinal("TPhone");
                    int TeacherSub = reader.GetOrdinal("TSub");
                    int TeacherAdd = reader.GetOrdinal("TAdd");
                   


                    Key = 0;
                    TnameTb.Text = reader.GetString(TeacherName);
                    TGenCb.SelectedIndex = TGenCb.FindString(reader.GetString(TeacherGender));

                    DateTime date = reader.GetDateTime(TeacherDate);

                    TDate.Value = date;

                    SubCb.SelectedIndex = SubCb.FindString(reader.GetString(TeacherSub));
                    TPhoneTb.Text = reader.GetString(TeacherPhone);

                    TAddTb.Text = reader.GetString(TeacherAdd);

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

        private void TeachersDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Key = Convert.ToInt32(TeachersDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            TnameTb.Text = TeachersDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
            TGenCb.SelectedItem = TeachersDGV.Rows[e.RowIndex].Cells[2].Value.ToString();
            SubCb.SelectedItem = TeachersDGV.Rows[e.RowIndex].Cells[4].Value.ToString();
            TPhoneTb.Text = TeachersDGV.Rows[e.RowIndex].Cells[3].Value.ToString();
            TAddTb.Text = TeachersDGV.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void TeachersDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
