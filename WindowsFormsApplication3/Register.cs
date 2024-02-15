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

namespace WindowsFormsApplication3
{
    public partial class Register : Form
    {

        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        //database connection

        public Register()
        {
            InitializeComponent();
            txtfname.Focus();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Home obj4 = new Home();
            this.Hide();
            obj4.Show();
        }//go back to home

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtaddress.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            txtnic.Clear();
            dob.ResetText();
            rbmale.Checked = false;
            rbfemale.Checked = false;
            txtmonthlysalary.Clear();
            txtotrate.Clear();
            txtallowances.Clear();
            txtfname.Focus();
        }//clear button , clear all fields

        private void btnnext_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    //Register
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee VALUES(@fname,@lname,@dob,@gender,@address,@email,@contactno,@nic,@monthlysalary,@otrate,@allowances)", cnn);

                    cmd.Parameters.AddWithValue("@fname", txtfname.Text);
                    cmd.Parameters.AddWithValue("@lname", txtlname.Text);
                    cmd.Parameters.AddWithValue("@dob", dob.Value);
                    string gender;
                    if (rbmale.Checked) gender = "Male"; else gender = "Female";
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@contactno", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@nic", txtnic.Text);
                    cmd.Parameters.AddWithValue("@monthlysalary", txtmonthlysalary.Text);
                    cmd.Parameters.AddWithValue("@otrate", txtotrate.Text);
                    cmd.Parameters.AddWithValue("@allowances", txtallowances.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New Employee Registered Successfully!", "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clear
                    txtfname.Clear();
                    txtlname.Clear();
                    txtaddress.Clear();
                    txtcontact.Clear();
                    txtemail.Clear();
                    txtnic.Clear();
                    dob.ResetText();
                    rbmale.Checked = false;
                    rbfemale.Checked = false;
                    txtmonthlysalary.Clear();
                    txtotrate.Clear();
                    txtallowances.Clear();
                    txtfname.Focus();

                    cnn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }//register employee,save employee data to the database


    }
}
