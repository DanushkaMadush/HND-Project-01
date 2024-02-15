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
    public partial class Paysheet : Form
    {
        public string EmployeeIDValue { get; set; }
        public string MonthValue { get; set; }

        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public Paysheet()
        {
            InitializeComponent();
            fillcombobox();

            
        }//form load

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeID.DataSource = dt;
            cmbemployeeID.DisplayMember = "Employee_ID";
            cmbemployeeID.ValueMember = "Employee_ID";
        }//fill combo box

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.Show();
        }//home button 

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbmonth.ResetText();
            this.ActiveControl = cmbemployeeID;
        }//clear button

        private void btnviewpaysheet_Click(object sender, EventArgs e)
        {
            try
            {

            EmployeeIDValue = cmbemployeeID.Text;
            MonthValue = cmbmonth.Text;
            cnn.Close();
            Viewpaysheet viewpaysheetForm = new Viewpaysheet();

            // Load values to textboxes in Viewpaysheet
            viewpaysheetForm.LoadValues(EmployeeIDValue, MonthValue);

            // Show the Viewpaysheet form
            viewpaysheetForm.Show();
            this.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }//viewpaysheet button





    }
}
