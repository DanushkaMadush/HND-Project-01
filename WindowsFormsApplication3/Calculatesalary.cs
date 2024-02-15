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
    public partial class Calculatesalary : Form
    {

        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public Calculatesalary()
        {
            InitializeComponent();
            fillcombobox();
            this.ActiveControl = cmbemployeeID;//focus combo box when loading form
            txtgtax.Text = 1.5.ToString("N2"); 
        }

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeID.DataSource = dt;
            cmbemployeeID.DisplayMember = "Employee_ID";
            cmbemployeeID.ValueMember = "Employee_ID";
        }//fill combo box

        private void load_details()
        {
            try
            {
                cnn.Open();
                
                using (SqlCommand cmdemployee = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID=@employeeID", cnn))
                {
                    //SqlCommand cmdemployee = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID=@employeeID", cnn);      
                    cmdemployee.Parameters.AddWithValue("@employeeID", cmbemployeeID.Text);
                    SqlDataReader dr1 = cmdemployee.ExecuteReader();
                    if (dr1.Read())
                    {
                        txtmonthlysalary.Text = dr1[9].ToString();
                        txtallowances.Text = dr1[11].ToString();
                        txtotrate.Text = dr1[10].ToString();
                    }
                    else
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        } //load employee table details

        private void load_otdetails()
        {
            try
            {
                cnn.Open();
                using (SqlCommand cmdot = new SqlCommand("SELECT * FROM ot_value WHERE Employee_ID=@employeeID AND Month=@month", cnn))
                {
                    cmdot.Parameters.AddWithValue("@employeeID", cmbemployeeID.Text);
                    cmdot.Parameters.AddWithValue("@month", cmbmonth.Text);
                    SqlDataReader dr2 = cmdot.ExecuteReader();
                    if (dr2.Read())
                    {
                        txtnormalot.Text = dr2[2].ToString();
                        txtnormalotvalue.Text = dr2[3].ToString();
                        txtdoubleot.Text = dr2[4].ToString();
                        txtdoubleotvalue.Text = dr2[5].ToString();
                        txttripleot.Text = dr2[6].ToString();
                        txttripleotvalue.Text = dr2[7].ToString();
                        txttotalotvalue.Text = dr2[8].ToString();
                    }
                    else
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//load add_ot table details  

        private void load_daterange()
        {
            try
            {
                cnn.Open();

                using (SqlCommand cmddaterange = new SqlCommand("SELECT * FROM month_table WHERE month=@month", cnn))
                {
                    cmddaterange.Parameters.AddWithValue("@month",cmbmonth.Text);
                    SqlDataReader dr3 = cmddaterange.ExecuteReader();
                    if (dr3.Read())
                    {
                        txttotalworkingdays.Text=dr3[5].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Date Range ERROR!");
                    }
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//load date range from month table

        private void cmbemployeeID_Leave(object sender, EventArgs e)
        {
            load_details();
        }//actions when combo box employee id leave

        private void cmbmonth_Leave(object sender, EventArgs e)
        {
            load_otdetails();
            load_daterange();
            //payment_done();
        }//actions when combo box month leave 

        private void txtabsentdays_Leave(object sender, EventArgs e)
        {
            decimal monthlysalary = decimal.Parse(txtmonthlysalary.Text);
            decimal daterange = decimal.Parse(txttotalworkingdays.Text);
            decimal absentdays = decimal.Parse(txtabsentdays.Text);
            decimal nopayvalue = (monthlysalary / daterange) * absentdays;

            txtnopayvalue.Text = nopayvalue.ToString("N2");

        }//calculate no pay value when leave absent days text box

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //calculate base pay value
            decimal monthlysalary=decimal.Parse(txtmonthlysalary.Text);
            decimal allowances=decimal.Parse(txtallowances.Text);
            decimal totalot=decimal.Parse(txttotalotvalue.Text);
            decimal basepayvalue = monthlysalary + allowances + totalot;
            txtbasepay.Text = basepayvalue.ToString();

            //calculate tax value
            decimal gtax = decimal.Parse(txtgtax.Text);
            decimal gtaxvalue = basepayvalue * gtax/100;
            txtgtaxvalue.Text = gtaxvalue.ToString("N2");

            //calculate deductions
            decimal nopayvalue=decimal.Parse(txtnopayvalue.Text);
            decimal deductions = gtaxvalue + nopayvalue;
            txtdeductions.Text = deductions.ToString("N2");

            //calculate gross salary
            decimal grosspayvalue = basepayvalue - deductions;
            txtgrosspay.Text = grosspayvalue.ToString("N2");

        }//calculate gross salary

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO salary_table VALUES (@employee_id,@month,@daterange,@absentdays,@nopayvalue,@gtax,@gtaxvalue,@basepay,@deductions,@grosspay)", cnn);
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO leave_record VALUES (@employee_id,@month,@absentdays)", cnn);

                    cmd.Parameters.AddWithValue("@employee_id", cmbemployeeID.Text);
                    cmd.Parameters.AddWithValue("@month", cmbmonth.Text);
                    cmd.Parameters.AddWithValue("@daterange", Convert.ToDecimal(txttotalworkingdays.Text));
                    cmd.Parameters.AddWithValue("@absentdays", Convert.ToDecimal(txtabsentdays.Text));
                    cmd.Parameters.AddWithValue("@nopayvalue", Convert.ToDecimal(txtnopayvalue.Text));
                    cmd.Parameters.AddWithValue("@gtax", Convert.ToDecimal(txtgtax.Text));
                    cmd.Parameters.AddWithValue("@gtaxvalue", Convert.ToDecimal(txtgtaxvalue.Text));
                    cmd.Parameters.AddWithValue("@basepay", Convert.ToDecimal(txtbasepay.Text));
                    cmd.Parameters.AddWithValue("@deductions", Convert.ToDecimal(txtdeductions.Text));
                    cmd.Parameters.AddWithValue("@grosspay", Convert.ToDecimal(txtgrosspay.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salary Details Saved Successfully!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmd1.Parameters.AddWithValue("@employee_id", cmbemployeeID.Text);
                    cmd1.Parameters.AddWithValue("@month", cmbmonth.Text);
                    cmd1.Parameters.AddWithValue("@absentdays", Convert.ToDecimal(txtabsentdays.Text));
                    cmd1.ExecuteNonQuery();

                    //Clear

                    this.ActiveControl = cmbemployeeID;
                    txtmonthlysalary.Clear();
                    txtallowances.Clear();
                    cmbmonth.ResetText();
                    txttotalworkingdays.Clear();
                    txtotrate.Clear();
                    txtnormalot.Clear();
                    txtnormalotvalue.Clear();
                    txtdoubleot.Clear();
                    txtdoubleotvalue.Clear();
                    txttripleot.Clear();
                    txttripleotvalue.Clear();
                    txttotalotvalue.Clear();
                    txtabsentdays.Clear();
                    txtnopayvalue.Clear();
                    //txtgtax.Clear();
                    txtgtaxvalue.Clear();
                    txtbasepay.Clear();
                    txtdeductions.Clear();
                    txtgrosspay.Clear();

                    cnn.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//save details 

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.ActiveControl = cmbemployeeID;
            txtmonthlysalary.Clear();
            txtallowances.Clear();
            cmbmonth.ResetText();
            txttotalworkingdays.Clear();
            txtotrate.Clear();
            txtnormalot.Clear();
            txtnormalotvalue.Clear();
            txtdoubleot.Clear();
            txtdoubleotvalue.Clear();
            txttripleot.Clear();
            txttripleotvalue.Clear();
            txttotalotvalue.Clear();
            txtabsentdays.Clear();
            txtnopayvalue.Clear();
            //txtgtax.Clear();
            txtgtaxvalue.Clear();
            txtbasepay.Clear();
            txtdeductions.Clear();
            txtgrosspay.Clear();

        }//clear details

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.Show();
        }//go back to home page

        private void payment_done()
        {
            try
            {
                cnn.Open();

                using (SqlCommand cmdload = new SqlCommand("SELECT * FROM salary_table WHERE Employee_ID=@employeeID AND Month=@month", cnn))
                {
                    cmdload.Parameters.AddWithValue("@employeeID", cmbemployeeID.Text);
                    cmdload.Parameters.AddWithValue("@month", cmbmonth.Text);
                    SqlDataReader dr = cmdload.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("This Employee salary for this month already saved!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    else
                    {
                        
                    }
                }

                cnn.Close();
                txtmonthlysalary.Clear();
                txtallowances.Clear();
                cmbmonth.ResetText();
                txttotalworkingdays.Clear();
                txtotrate.Clear();
                txtnormalot.Clear();
                txtnormalotvalue.Clear();
                txtdoubleot.Clear();
                txtdoubleotvalue.Clear();
                txttripleot.Clear();
                txttripleotvalue.Clear();
                txttotalotvalue.Clear();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//error when already saved employee AND month , this is not completed yet!!!










    }
}
