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
    public partial class CalculateOT : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public CalculateOT()
        {
            InitializeComponent();
            this.ActiveControl = cmbemployeeID;
            fillcombobox();
        }

        private void CalculateOT_Load(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.Show();
        }//go back to home form

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbemployeeID.ResetText();
            this.ActiveControl = cmbemployeeID;
            cmbmonth.ResetText();
            txtotrate.Clear();
            datefrom.ResetText();
            dateto.ResetText();
            txtnormalot.Clear();
            txtdoubleot.Clear();
            txttripleot.Clear();
            txtnormalvalue.Clear();
            txtdoublevalue.Clear();
            txttriplevalue.Clear();
            txttotal.Clear();
            
        }//clear button

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeID.DataSource = dt;
            cmbemployeeID.DisplayMember = "Employee_ID";
            cmbemployeeID.ValueMember = "Employee_ID";
        }//combo box fill with employee_ID

        private void load_details()
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID=@employeeID",cnn);
                cmd.Parameters.AddWithValue("@employeeID" , cmbemployeeID.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                
                if(dr.Read())
                {
                    txtotrate.Text=dr[10].ToString();
                }

                else
                {
                    MessageBox.Show("Employee Not Found");
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//load  otrate from db

        private void cmbemployeeID_Leave(object sender, EventArgs e)
        {
            load_details();
        }//load otrate from db when leave combo box & if there is already saved details update enable

        private void load_ot()
        {

            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand(" SELECT SUM(ot_hours) AS ot_total,SUM(double_ot) AS double_total,SUM(triple_ot) AS triple_total FROM  add_ot WHERE Employee_ID = @EmployeeID AND date BETWEEN @startdate AND @enddate;",cnn);

                cmd.Parameters.AddWithValue("@EmployeeID", cmbemployeeID.Text);
                cmd.Parameters.AddWithValue("@startdate", datefrom.Value);
                cmd.Parameters.AddWithValue("@enddate" , dateto.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    txtnormalot.Text = dr[0].ToString();
                    txtdoubleot.Text = dr[1].ToString();
                    txttripleot.Text = dr[2].ToString();
                }
                else
                {
                    MessageBox.Show("No Overtime Found!");
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//load ot sum to ot fields

        private void dateto_Leave(object sender, EventArgs e)
        {
            load_ot();
        }//load ot sum details when leave 2nd datetimepicker

        private void btncalulate_Click(object sender, EventArgs e)
        {
                    {
            int normalot = 0;
            int doubleot = 0;
            int tripleot = 0;
            decimal otrate = 0;
            int normalotvalue = 0;
            int doubleotvalue = 0;
            int tripleotvalue = 0;

            
            if (int.TryParse(txtnormalot.Text, out normalot) &&
                int.TryParse(txtdoubleot.Text, out doubleot) &&
                int.TryParse(txttripleot.Text, out tripleot) &&
                decimal.TryParse(txtotrate.Text, out otrate))
            {
                
                normalotvalue = (int)(normalot * otrate);
                doubleotvalue = (int)(doubleot * otrate);
                tripleotvalue = (int)(tripleot * otrate);
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numeric values.");
            }

            
            txtnormalvalue.Text = normalotvalue.ToString();
            txtdoublevalue.Text = doubleotvalue.ToString();
            txttriplevalue.Text = tripleotvalue.ToString();

            int total = normalotvalue + doubleotvalue + tripleotvalue;
            txttotal.Text = total.ToString();
        }
        }//calculate button , calculate ot values

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ot_value VALUES (@Employee_ID , @month , @normalot , @normalotvalue , @doubleot , @doubleotvalue , @tripleot , @tripleotvalue , @total , @datefrom , @dateto)", cnn);
                    cmd.Parameters.AddWithValue("@Employee_ID", cmbemployeeID.Text);
                    cmd.Parameters.AddWithValue("@month", cmbmonth.Text);
                    cmd.Parameters.AddWithValue("@normalotvalue", txtnormalvalue.Text);
                    cmd.Parameters.AddWithValue("@normalot", txtnormalot.Text);
                    cmd.Parameters.AddWithValue("@doubleotvalue", txtdoublevalue.Text);
                    cmd.Parameters.AddWithValue("@doubleot", txtdoubleot.Text);
                    cmd.Parameters.AddWithValue("@tripleotvalue", txttriplevalue.Text);
                    cmd.Parameters.AddWithValue("@tripleot", txttripleot.Text);
                    cmd.Parameters.AddWithValue("@total", txttotal.Text);
                    cmd.Parameters.AddWithValue("@datefrom", datefrom.Value);
                    cmd.Parameters.AddWithValue("@dateto", dateto.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Saved!");


                    this.ActiveControl = cmbemployeeID;
                    cmbmonth.ResetText();
                    txtotrate.Clear();
                    datefrom.ResetText();
                    dateto.ResetText();
                    txtnormalot.Clear();
                    txtdoubleot.Clear();
                    txttripleot.Clear();
                    txtnormalvalue.Clear();
                    txtdoublevalue.Clear();
                    txttriplevalue.Clear();
                    txttotal.Clear();

                    cnn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//save ot values to db

        private void loadupdate_details()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM ot_value WHERE Employee_ID=@employeeID AND month=@month;", cnn);
                cmd.Parameters.AddWithValue("@employeeID", cmbemployeeID.Text);
                cmd.Parameters.AddWithValue("@month" , cmbmonth.Text);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtnormalot.Text=dr[2].ToString();
                    txtnormalvalue.Text=dr[3].ToString();
                    txtdoubleot.Text = dr[4].ToString();
                    txtdoublevalue.Text = dr[5].ToString();
                    txttripleot.Text = dr[6].ToString();
                    txttriplevalue.Text = dr[7].ToString();
                    txttotal.Text = dr[8].ToString();
                    
                    DateTime fromDate, toDate;
                    if (DateTime.TryParse(dr[9].ToString(), out fromDate))
                    {
                        datefrom.Value = fromDate;
                    }
                    else
                    {
                        MessageBox.Show("Date Error!");
                    }

                    if (DateTime.TryParse(dr[10].ToString(), out toDate))
                    {
                        dateto.Value = toDate;
                    }
                    else
                    {
                        MessageBox.Show("Date Error!");
                    }

                    
                    btnupdate.Enabled = true;
                    btnsave.Enabled = false;
                }

                else
                {
                    btnsave.Enabled = true;
                    btnupdate.Enabled = false;
                }

                cnn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbmonth_Leave(object sender, EventArgs e)
        {
            loadupdate_details();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE ot_value SET normalot=@normalot , normalot_value=@normalotvalue , doubleot=@doubleot , doubleot_value=@doubleotvalue , tripleot=@tripleot , tripleot_value=@tripleotvalue , total=@total , from_date=@datefrom , to_date=@dateto WHERE Employee_ID=@Employee_ID AND month=@month", cnn);
                    cmd.Parameters.AddWithValue("@Employee_ID", cmbemployeeID.Text);
                    cmd.Parameters.AddWithValue("@month", cmbmonth.Text);
                    cmd.Parameters.AddWithValue("@normalotvalue", txtnormalvalue.Text);
                    cmd.Parameters.AddWithValue("@normalot", txtnormalot.Text);
                    cmd.Parameters.AddWithValue("@doubleotvalue", txtdoublevalue.Text);
                    cmd.Parameters.AddWithValue("@doubleot", txtdoubleot.Text);
                    cmd.Parameters.AddWithValue("@tripleotvalue", txttriplevalue.Text);
                    cmd.Parameters.AddWithValue("@tripleot", txttripleot.Text);
                    cmd.Parameters.AddWithValue("@total", txttotal.Text);
                    cmd.Parameters.AddWithValue("@datefrom", datefrom.Value);
                    cmd.Parameters.AddWithValue("@dateto", dateto.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Updated!!");


                    this.ActiveControl = cmbemployeeID;
                    cmbmonth.ResetText();
                    txtotrate.Clear();
                    datefrom.ResetText();
                    dateto.ResetText();
                    txtnormalot.Clear();
                    txtdoubleot.Clear();
                    txttripleot.Clear();
                    txtnormalvalue.Clear();
                    txtdoublevalue.Clear();
                    txttriplevalue.Clear();
                    txttotal.Clear();

                    cnn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }








    }
}
