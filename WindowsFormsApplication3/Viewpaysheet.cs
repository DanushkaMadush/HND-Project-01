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
using System.IO;
//using iTextSharp.Text;
//using iTextSharp.Text.pdf;

namespace WindowsFormsApplication3
{
    public partial class Viewpaysheet : Form
    {
       

        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public Viewpaysheet()
        {

            InitializeComponent();
            
            
        }
       
        private void load_details()
        {
            try
            {
                cnn.Open();

                //load details from employee table
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID=@employeeid",cnn);
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM ot_value WHERE Employee_ID=@employeeid AND month=@month;", cnn);
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM salary_table WHERE Employee_ID=@employeeid AND month=@month;", cnn);

                cmd.Parameters.AddWithValue("@employeeid" , txtemployeeID.Text);
                cmd1.Parameters.AddWithValue("@employeeid", txtemployeeID.Text);
                cmd1.Parameters.AddWithValue("@month", txtmonth.Text);
                cmd2.Parameters.AddWithValue("@employeeid", txtemployeeID.Text);
                cmd2.Parameters.AddWithValue("@month", txtmonth.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    txtfname.Text=dr[1].ToString();
                    txtlname.Text = dr[2].ToString();
                    txtmonthlysalary.Text = dr[9].ToString();
                    txtallowances.Text = dr[11].ToString();
                    txtnormalot.Text=dr1[2].ToString();
                    txtnormalotvalue.Text = dr1[3].ToString();
                    txtdoubleot.Text = dr1[4].ToString();
                    txtdoubleotvalue.Text = dr1[5].ToString();
                    txttripleot.Text = dr1[6].ToString();
                    txttripleotvalue.Text = dr1[7].ToString();
                    txttotalotvalue.Text = dr1[8].ToString();
                    txtbasepayvalue.Text=dr2[7].ToString();
                    txtabsentdays.Text = dr2[3].ToString();
                    txtnopayvalue.Text=dr2[4].ToString();
                    txtgtax.Text=dr2[6].ToString();
                    txtgrosspay.Text = dr2[9].ToString();
                }
                else
                {
                    MessageBox.Show("Employee NOT Found!");
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//load details

        private void load_detailss()
        {
            try
            {
                cnn.Open();

                // Load details from the employee table
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID=@employeeid", cnn))
                {
                    cmd.Parameters.AddWithValue("@employeeid", txtemployeeID.Text);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtfname.Text = dr[1].ToString();
                            txtlname.Text = dr[2].ToString();
                            txtmonthlysalary.Text = dr[9].ToString();
                            txtallowances.Text = dr[11].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Employee NOT Found!");
                            return; 
                        }
                    }
                }

                // Load details from the ot_value table
                using (SqlCommand cmd1 = new SqlCommand("SELECT * FROM ot_value WHERE Employee_ID=@employeeid AND month=@month", cnn))
                {
                    cmd1.Parameters.AddWithValue("@employeeid", txtemployeeID.Text);
                    cmd1.Parameters.AddWithValue("@month", txtmonth.Text);
                    using (SqlDataReader dr1 = cmd1.ExecuteReader())
                    {
                        if (dr1.Read())
                        {
                            txtnormalot.Text = dr1[2].ToString();
                            txtnormalotvalue.Text = dr1[3].ToString();
                            txtdoubleot.Text = dr1[4].ToString();
                            txtdoubleotvalue.Text = dr1[5].ToString();
                            txttripleot.Text = dr1[6].ToString();
                            txttripleotvalue.Text = dr1[7].ToString();
                            txttotalotvalue.Text = dr1[8].ToString();
                        }
                    }
                }

                // Load details from the salary_table table
                using (SqlCommand cmd2 = new SqlCommand("SELECT * FROM salary_table WHERE Employee_ID=@employeeid AND month=@month", cnn))
                {
                    cmd2.Parameters.AddWithValue("@employeeid", txtemployeeID.Text);
                    cmd2.Parameters.AddWithValue("@month", txtmonth.Text);
                    using (SqlDataReader dr2 = cmd2.ExecuteReader())
                    {
                        if (dr2.Read())
                        {
                            // ... continue with fields from salary_table table
                            txtbasepayvalue.Text = dr2[7].ToString();
                            txtabsentdays.Text = dr2[3].ToString();
                            txtnopayvalue.Text = dr2[4].ToString();
                            txtgtax.Text = dr2[6].ToString();
                            txtgrosspay.Text = dr2[9].ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Always close the connection in the finally block
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }//load details-using block

        public void LoadValues(string employeeID, string month)
        {
            txtemployeeID.Text = employeeID;
            txtmonth.Text = month;
        }//load variables to employee id & month

        private void txtmonth_Leave(object sender, EventArgs e)
        {
            //load_detailss();
        }//load detailss-- when leave month text box , tried to load details when loading form but not successed

        private void btnback_Click(object sender, EventArgs e)
        {
            Paysheet obj1 = new Paysheet();
            this.Hide();
            obj1.Show();
        }//back to paysheet 

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void txtmonth_TextChanged(object sender, EventArgs e)
        {
            load_detailss();
        }





 


    }
}
