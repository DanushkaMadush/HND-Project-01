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
    public partial class AddOT : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public AddOT()
        {
            InitializeComponent();
            this.ActiveControl = cmbemployeeid;
            fillcombobox();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.Show();
        }//Home Button , go back to home page

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbemployeeid.ResetText();
            dateot.ResetText();
            txtnormalot.Clear();
            txtdoubleot.Clear();
            txttripleot.Clear();
            this.ActiveControl = cmbemployeeid;
        }//Clear Button , clear all the fields

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeid.DataSource = dt;
            cmbemployeeid.DisplayMember = "Employee_ID";
            cmbemployeeid.ValueMember = "Employee_ID";
        }//combo box fill with employee_ID

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO add_ot (Employee_ID , date , ot_hours , double_ot , triple_ot) VALUES (@employeeID , @date , @othours , @doubleot , @trippleot)", cnn);
                cmd.Parameters.AddWithValue("@employeeID", cmbemployeeid.Text);
                cmd.Parameters.AddWithValue("@date",dateot.Value);
                cmd.Parameters.AddWithValue("@othours", txtnormalot.Text);
                cmd.Parameters.AddWithValue("@doubleot", txtdoubleot.Text);
                cmd.Parameters.AddWithValue("@trippleot", txttripleot.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Details Saved!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmbemployeeid.ResetText();
                dateot.ResetText();
                txtnormalot.Clear();
                txtdoubleot.Clear();
                txttripleot.Clear();
                this.ActiveControl = cmbemployeeid;

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//save data

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateOT objnew = new UpdateOT();
            this.Hide();
            objnew.Show();

        }//ot data update form show

        private void dateto_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                dataGridView1.Rows.Clear();

                SqlCommand cmd = new SqlCommand("SELECT date, ot_hours , double_ot , triple_ot FROM add_ot WHERE Employee_ID = @Employee_ID AND date BETWEEN @startdate AND @enddate; ", cnn);
                cmd.Parameters.AddWithValue("@Employee_ID" , cmbemployeeid.Text);
                cmd.Parameters.AddWithValue("@startdate",datefrom.Value);
                cmd.Parameters.AddWithValue("@enddate",dateto.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //int count = 1;
                //foreach (DataRow dr in dt.Rows)
                //{
                 //   dataGridView1.Rows.Add(count.ToString(), dr["date"].ToString(),
                   //     dr["ot_hours"].ToString(), dr["double_ot"].ToString(), dr["triple_OT"].ToString());
                    //count++;
                //}

                

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
