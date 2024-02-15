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
    public partial class Month : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        //Database Connection----------------------------------------------------------------------------------------------------------

        public Month()
        {
            InitializeComponent();
            this.ActiveControl = cmbmonth;
        }


        private void txtHolidays_Leave(object sender, EventArgs e)
        {
            int daterange = int.Parse(txtDateRange.Text);
            int holidays = int.Parse(txtHolidays.Text);
            int totalworkingdays = daterange - holidays;
            txttotalworkingdays.Text = totalworkingdays.ToString();
        }//calculate total working days & output in last textbox

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.Show();
        }//Home button , Go back to home

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbmonth.ResetText();
            monthStartDate.ResetText();
            monthEndDate.ResetText();
            txtDateRange.Clear();
            txtHolidays.Clear();
            txttotalworkingdays.Clear();
        }//Clear Button , Clear all fields

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO month_table VALUES (@month , @startdate , @enddate , @daterange , @holidays , @total);", cnn);
                cmd.Parameters.AddWithValue("@month" , cmbmonth.Text);
                cmd.Parameters.AddWithValue("@startdate", monthStartDate.Value);
                cmd.Parameters.AddWithValue("@enddate", monthEndDate.Value);
                cmd.Parameters.AddWithValue("@daterange", txtDateRange.Text);
                cmd.Parameters.AddWithValue("@holidays", txtHolidays.Text);
                cmd.Parameters.AddWithValue("@total", txttotalworkingdays.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Details Saved!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbmonth.ResetText();
                monthStartDate.ResetText();
                monthEndDate.ResetText();
                txtDateRange.Clear();
                txtHolidays.Clear();
                txttotalworkingdays.Clear();

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Save Button , Save data to db

        private void load_details()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM month_table WHERE month=@month",cnn);
                cmd.Parameters.AddWithValue("@month" , cmbmonth.Text);
                
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    monthStartDate.Text = dr[1].ToString();
                    monthEndDate.Text = dr[2].ToString();
                    txtDateRange.Text = dr[3].ToString();
                    txtHolidays.Text = dr[4].ToString();
                    txttotalworkingdays.Text = dr[5].ToString();
                }
                else
                {
                    MessageBox.Show("Please add new details");
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//Load details to form

        private void cmbmonth_Leave(object sender, EventArgs e)
        {
            load_details();
        }//load details when leaving combobox






    }
}
