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
    public partial class View : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);
        

        public View()
        {
            InitializeComponent();
            fillcombobox();
            this.ActiveControl = cmbemployeeID;//focus combo box when loading form
            
            
        }

        //combo box populate--------------------------------------------------------------------------------------------------------------//
        
        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee",cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeID.DataSource = dt;
            cmbemployeeID.DisplayMember = "Employee_ID";
            cmbemployeeID.ValueMember = "Employee_ID";
        }

        //----------------------------------------------------------------------------------------------------------------------------------//


        //Load details when select combo box--------------------------------------------------------------------------------------------------//

        private void load_employee()
        {
            try
            {

                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID=@Employee_ID", cnn);
                    cmd.Parameters.AddWithValue("@Employee_ID", cmbemployeeID.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtfname.Text = dr[1].ToString();
                        txtlname.Text = dr[2].ToString();
                        dob.Text = dr[3].ToString();

                        string gender = dr[4].ToString().Trim();
                        if (string.Equals(gender, "Female"))
                            rbfemale.Checked = true;
                        else
                            rbmale.Checked = true;


                        txtaddress.Text = dr[5].ToString();
                        txtemail.Text = dr[6].ToString();
                        txtcontact.Text = dr[7].ToString();
                        txtnic.Text = dr[8].ToString();
                        txtmonthlysalary.Text = dr[9].ToString();
                        txtotrate.Text = dr[10].ToString();
                        txtallowances.Text = dr[11].ToString();
                    }

                    else
                    {
                        MessageBox.Show("Employee Not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    cnn.Close();
                }
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //---------------------------------------------------------------------------------------------------------------------------------------//

        private void btnclear_Click(object sender, EventArgs e) //clear button , clear all form fields//
        {
            cmbemployeeID.ResetText();
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
            this.ActiveControl = cmbemployeeID;
            
        }

        private void btnhome_Click(object sender, EventArgs e)//home button , go back to home page
        {
            Home obj4 = new Home();
            this.Hide();
            obj4.Show();
            
        }

        private void cmbemployeeID_Leave(object sender, EventArgs e)
        {
            load_employee();
        }//fill other fields when leave combo box

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Employee SET fname=@fname,lname=@lname,dob=@dob,gender=@gender,address=@address,email=@email,contactNo=@contactno,nic=@nic,monthlySalary=@monthlysalary,otrate=@otrate,allowances=@allowances WHERE Employee_ID=@Eno", cnn);

                    cmd.Parameters.AddWithValue("@Eno", cmbemployeeID.Text);
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
                    MessageBox.Show("Employee Details Update Successfully!", "Details Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    cmbemployeeID.ResetText();
                    this.ActiveControl = cmbemployeeID;


                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//update employee details

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
            
                cnn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Employee_ID=@Eno", cnn);

                cmd.Parameters.AddWithValue("@Eno", cmbemployeeID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Record Delete Successfully!", "Record Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                cmbemployeeID.ResetText();
                this.ActiveControl = cmbemployeeID;
                

                cnn.Close();
            }}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        
        }//delete employee record

        private void cmbemployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load_employee();
        }

     
        


    }
}
