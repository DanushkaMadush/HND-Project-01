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
    public partial class Leaveform : Form
    {
        static string connectionstr = "Data Source=DESKTOP-EBP1U9N\\SQLEXPRESS;Initial Catalog=Grifindo;Integrated Security=True;";

        SqlConnection cnn = new SqlConnection(connectionstr);

        public Leaveform()
        {
            InitializeComponent();
            fillcombobox();
        }

        private void fillcombobox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Employee_ID from Employee", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbemployeeid.DataSource = dt;
            cmbemployeeid.DisplayMember = "Employee_ID";
            cmbemployeeid.ValueMember = "Employee_ID";
        }//combo box fill with employee_ID

        private void cmbemployeeid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();

                // Clear the data source of the DataGridView
                dataGridView1.DataSource = null;

                DataRowView selectedRow = (DataRowView)cmbemployeeid.SelectedItem;
                string employeeID = selectedRow["Employee_ID"].ToString();

                SqlCommand cmd = new SqlCommand("SELECT month, absent_days FROM leave_record WHERE Employee_ID = @Employee_ID", cnn);
                cmd.Parameters.AddWithValue("@Employee_ID", employeeID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Set the data source of the DataGridView to the new DataTable
                dataGridView1.DataSource = dt;

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//view leave data in datagrid

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home obj1 = new Home();
            this.Hide();
            obj1.Show();
        }
    }
}
