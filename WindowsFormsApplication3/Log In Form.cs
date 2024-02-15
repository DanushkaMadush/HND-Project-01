using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "Admin" && password == "Grifindo")
            {
                Home obj1 = new Home();
                this.Hide();
                obj1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials , Please Try Again.","Invalid Login Details",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtpassword.Clear();
                txtusername.Clear();
                txtusername.Focus();
            }
        }
    }
}
