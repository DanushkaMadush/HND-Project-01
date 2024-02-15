using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//exit application

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login obj2 = new login();
            this.Hide();
            obj2.Show();
        }//go to login form

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register obj3 = new Register();
            this.Hide();
            obj3.Show();
        }//go to register form

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View obj4 = new View();
            this.Hide();
            obj4.Show();
        }//go to view form

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Month obj5 = new Month();
            this.Hide();
            obj5.Show();
        }//go to month form

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leaveform obj6 = new Leaveform();
            this.Hide();
            obj6.Show();
        }//go to leave form

        private void addOvertimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOT obj7 = new AddOT();
            this.Hide();
            obj7.Show();
        }//go to add ot form

        private void calculateOvertimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateOT obj8 = new CalculateOT();
            this.Hide();
            obj8.Show();
        }//go to calculate ot form 

        private void calculateSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculatesalary obj9 = new Calculatesalary();
            this.Hide();
            obj9.Show();
        }//go to calculate salary form

        private void viewPaysheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paysheet obj10 = new Paysheet();
            this.Hide();
            obj10.Show();
        }//go to paysheet form


    }
}
