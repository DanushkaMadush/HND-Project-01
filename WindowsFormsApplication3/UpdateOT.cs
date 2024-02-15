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
    public partial class UpdateOT : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public UpdateOT()
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
        }//go back to home

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbemployeeid.ResetText();
            dateot.ResetText();
            txtnormalot.Clear();
            txtdoubleot.Clear();
            txttripleot.Clear();
            this.ActiveControl = cmbemployeeid;
        }//clear all fields

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeid.DataSource = dt;
            cmbemployeeid.DisplayMember = "Employee_ID";
            cmbemployeeid.ValueMember = "Employee_ID";
        }//combo box fill with employee_ID

        private void load_details()
        {
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM add_ot WHERE Employee_ID=@employeeID AND date=@date", cnn);
                cmd.Parameters.AddWithValue("@employeeID", cmbemployeeid.Text);
                cmd.Parameters.AddWithValue("@date",dateot.Value);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    txtnormalot.Text = dr[2].ToString();
                    txtdoubleot.Text = dr[3].ToString();
                    txttripleot.Text = dr[4].ToString();
                   
                    
                }
                else
                {
                    MessageBox.Show("No OT record saved for this day!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
                    
                    dateot.ResetText();
                    txtnormalot.Clear();
                    txtdoubleot.Clear();
                    txttripleot.Clear();
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//load details to text fields
        //this needs to complete//

        private void dateot_Leave(object sender, EventArgs e)
        {
            load_details();
        }

    }
}
