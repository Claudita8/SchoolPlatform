using SchoolPlatform.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolPlatform
{
    public partial class loginPlatform : Form
    {
        public loginPlatform()
        {
            InitializeComponent();
         this.passwordTb.UseSystemPasswordChar = !this.passwordTb.UseSystemPasswordChar;
        }
        
        
        private void reset_Click(object sender, EventArgs e)
        {
            usernameTb.Text = "";
            usernameTb.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "" || passwordTb.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
                return;
            } else if (usernameTb.Text == "admin" || passwordTb.Text == "1234")
            {
                Meniu meniu = new Meniu();
                meniu.Show();
            }
        }  

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            this.passwordTb.UseSystemPasswordChar = !this.passwordTb.UseSystemPasswordChar;
        }
    }
}
