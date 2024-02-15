namespace WindowsFormsApplication3
{
    partial class Calculatesalary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmonthlysalary = new System.Windows.Forms.TextBox();
            this.txtallowances = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbemployeeID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtotrate = new System.Windows.Forms.TextBox();
            this.txttripleotvalue = new System.Windows.Forms.TextBox();
            this.txtnormalotvalue = new System.Windows.Forms.TextBox();
            this.txtdoubleotvalue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttotalotvalue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttripleot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnormalot = new System.Windows.Forms.TextBox();
            this.txtdoubleot = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotalworkingdays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtnopayvalue = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtabsentdays = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtgtax = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtgrosspay = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtdeductions = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbasepay = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtgtaxvalue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(740, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 42);
            this.label9.TabIndex = 35;
            this.label9.Text = "Calculate Salary";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmonthlysalary);
            this.groupBox1.Controls.Add(this.txtallowances);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(280, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 171);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Payments";
            // 
            // txtmonthlysalary
            // 
            this.txtmonthlysalary.CausesValidation = false;
            this.txtmonthlysalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthlysalary.Location = new System.Drawing.Point(228, 48);
            this.txtmonthlysalary.Name = "txtmonthlysalary";
            this.txtmonthlysalary.ReadOnly = true;
            this.txtmonthlysalary.Size = new System.Drawing.Size(138, 27);
            this.txtmonthlysalary.TabIndex = 25;
            // 
            // txtallowances
            // 
            this.txtallowances.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtallowances.Location = new System.Drawing.Point(228, 90);
            this.txtallowances.Name = "txtallowances";
            this.txtallowances.ReadOnly = true;
            this.txtallowances.Size = new System.Drawing.Size(138, 27);
            this.txtallowances.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Allowances";
            // 
            // cmbemployeeID
            // 
            this.cmbemployeeID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemployeeID.FormattingEnabled = true;
            this.cmbemployeeID.Location = new System.Drawing.Point(541, 83);
            this.cmbemployeeID.Name = "cmbemployeeID";
            this.cmbemployeeID.Size = new System.Drawing.Size(124, 31);
            this.cmbemployeeID.TabIndex = 25;
            this.cmbemployeeID.Leave += new System.EventHandler(this.cmbemployeeID_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(358, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "Employee ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtotrate);
            this.groupBox2.Controls.Add(this.txttripleotvalue);
            this.groupBox2.Controls.Add(this.txtnormalotvalue);
            this.groupBox2.Controls.Add(this.txtdoubleotvalue);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txttotalotvalue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttripleot);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnormalot);
            this.groupBox2.Controls.Add(this.txtdoubleot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(280, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 296);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overtime Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "OT Rate";
            // 
            // txtotrate
            // 
            this.txtotrate.CausesValidation = false;
            this.txtotrate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotrate.Location = new System.Drawing.Point(228, 41);
            this.txtotrate.Name = "txtotrate";
            this.txtotrate.ReadOnly = true;
            this.txtotrate.Size = new System.Drawing.Size(115, 27);
            this.txtotrate.TabIndex = 24;
            // 
            // txttripleotvalue
            // 
            this.txttripleotvalue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttripleotvalue.Location = new System.Drawing.Point(289, 176);
            this.txttripleotvalue.Name = "txttripleotvalue";
            this.txttripleotvalue.ReadOnly = true;
            this.txttripleotvalue.Size = new System.Drawing.Size(116, 27);
            this.txttripleotvalue.TabIndex = 22;
            // 
            // txtnormalotvalue
            // 
            this.txtnormalotvalue.CausesValidation = false;
            this.txtnormalotvalue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalotvalue.Location = new System.Drawing.Point(289, 88);
            this.txtnormalotvalue.Name = "txtnormalotvalue";
            this.txtnormalotvalue.ReadOnly = true;
            this.txtnormalotvalue.Size = new System.Drawing.Size(116, 27);
            this.txtnormalotvalue.TabIndex = 20;
            // 
            // txtdoubleotvalue
            // 
            this.txtdoubleotvalue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoubleotvalue.Location = new System.Drawing.Point(289, 130);
            this.txtdoubleotvalue.Name = "txtdoubleotvalue";
            this.txtdoubleotvalue.ReadOnly = true;
            this.txtdoubleotvalue.Size = new System.Drawing.Size(116, 27);
            this.txtdoubleotvalue.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Total OT";
            // 
            // txttotalotvalue
            // 
            this.txttotalotvalue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalotvalue.Location = new System.Drawing.Point(228, 220);
            this.txttotalotvalue.Name = "txttotalotvalue";
            this.txttotalotvalue.ReadOnly = true;
            this.txttotalotvalue.Size = new System.Drawing.Size(115, 27);
            this.txttotalotvalue.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Triple OT";
            // 
            // txttripleot
            // 
            this.txttripleot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttripleot.Location = new System.Drawing.Point(228, 176);
            this.txttripleot.Name = "txttripleot";
            this.txttripleot.ReadOnly = true;
            this.txttripleot.Size = new System.Drawing.Size(45, 27);
            this.txttripleot.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Normal OT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Double OT";
            // 
            // txtnormalot
            // 
            this.txtnormalot.CausesValidation = false;
            this.txtnormalot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalot.Location = new System.Drawing.Point(228, 88);
            this.txtnormalot.Name = "txtnormalot";
            this.txtnormalot.ReadOnly = true;
            this.txtnormalot.Size = new System.Drawing.Size(45, 27);
            this.txtnormalot.TabIndex = 8;
            // 
            // txtdoubleot
            // 
            this.txtdoubleot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoubleot.Location = new System.Drawing.Point(228, 130);
            this.txtdoubleot.Name = "txtdoubleot";
            this.txtdoubleot.ReadOnly = true;
            this.txtdoubleot.Size = new System.Drawing.Size(45, 27);
            this.txtdoubleot.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotalworkingdays);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbmonth);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(956, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 171);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Month Details";
            // 
            // txttotalworkingdays
            // 
            this.txttotalworkingdays.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalworkingdays.Location = new System.Drawing.Point(198, 102);
            this.txttotalworkingdays.Name = "txttotalworkingdays";
            this.txttotalworkingdays.ReadOnly = true;
            this.txttotalworkingdays.Size = new System.Drawing.Size(114, 31);
            this.txttotalworkingdays.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 26);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total Working Days";
            // 
            // cmbmonth
            // 
            this.cmbmonth.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmonth.FormattingEnabled = true;
            this.cmbmonth.Items.AddRange(new object[] {
            "January 2024",
            "February 2024",
            "March 2024",
            "April 2024",
            "May 2024",
            "June 2024",
            "July 2024",
            "August 2024",
            "September 2024",
            "October 2024",
            "November 2024",
            "December 2024"});
            this.cmbmonth.Location = new System.Drawing.Point(198, 49);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(261, 31);
            this.cmbmonth.TabIndex = 28;
            this.cmbmonth.Leave += new System.EventHandler(this.cmbmonth_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "Month";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtnopayvalue);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.txtabsentdays);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(956, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 232);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Leave Details";
            // 
            // txtnopayvalue
            // 
            this.txtnopayvalue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnopayvalue.Location = new System.Drawing.Point(219, 83);
            this.txtnopayvalue.Name = "txtnopayvalue";
            this.txtnopayvalue.ReadOnly = true;
            this.txtnopayvalue.Size = new System.Drawing.Size(178, 31);
            this.txtnopayvalue.TabIndex = 32;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 26);
            this.label19.TabIndex = 31;
            this.label19.Text = "No Pay Value";
            // 
            // txtabsentdays
            // 
            this.txtabsentdays.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabsentdays.Location = new System.Drawing.Point(219, 37);
            this.txtabsentdays.Name = "txtabsentdays";
            this.txtabsentdays.Size = new System.Drawing.Size(83, 31);
            this.txtabsentdays.TabIndex = 30;
            this.txtabsentdays.Leave += new System.EventHandler(this.txtabsentdays_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 26);
            this.label14.TabIndex = 29;
            this.label14.Text = "Absent Days";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(949, 591);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(199, 26);
            this.label15.TabIndex = 25;
            this.label15.Text = "Government Tax Rate";
            // 
            // txtgtax
            // 
            this.txtgtax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgtax.Location = new System.Drawing.Point(1175, 591);
            this.txtgtax.Name = "txtgtax";
            this.txtgtax.Size = new System.Drawing.Size(115, 27);
            this.txtgtax.TabIndex = 26;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtgrosspay);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtdeductions);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtbasepay);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(280, 656);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(453, 208);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calculations";
            // 
            // txtgrosspay
            // 
            this.txtgrosspay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrosspay.Location = new System.Drawing.Point(219, 131);
            this.txtgrosspay.Name = "txtgrosspay";
            this.txtgrosspay.ReadOnly = true;
            this.txtgrosspay.Size = new System.Drawing.Size(147, 31);
            this.txtgrosspay.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(16, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 26);
            this.label16.TabIndex = 29;
            this.label16.Text = "Gross Pay";
            // 
            // txtdeductions
            // 
            this.txtdeductions.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeductions.Location = new System.Drawing.Point(219, 84);
            this.txtdeductions.Name = "txtdeductions";
            this.txtdeductions.ReadOnly = true;
            this.txtdeductions.Size = new System.Drawing.Size(147, 31);
            this.txtdeductions.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(16, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 26);
            this.label17.TabIndex = 27;
            this.label17.Text = "Deductions";
            // 
            // txtbasepay
            // 
            this.txtbasepay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbasepay.Location = new System.Drawing.Point(219, 37);
            this.txtbasepay.Name = "txtbasepay";
            this.txtbasepay.ReadOnly = true;
            this.txtbasepay.Size = new System.Drawing.Size(147, 31);
            this.txtbasepay.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(16, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 26);
            this.label18.TabIndex = 25;
            this.label18.Text = "Base Pay Value";
            // 
            // btnpayment
            // 
            this.btnpayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnpayment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.Location = new System.Drawing.Point(1716, 778);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(104, 40);
            this.btnpayment.TabIndex = 42;
            this.btnpayment.Text = "Payment";
            this.btnpayment.UseVisualStyleBackColor = false;
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(1720, 843);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 40);
            this.btnhome.TabIndex = 41;
            this.btnhome.Text = "<<Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(1594, 843);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 40);
            this.btnclear.TabIndex = 40;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(1595, 778);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 40);
            this.btnsave.TabIndex = 39;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncalculate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(1473, 778);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(104, 40);
            this.btncalculate.TabIndex = 43;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtgtaxvalue
            // 
            this.txtgtaxvalue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgtaxvalue.Location = new System.Drawing.Point(1321, 589);
            this.txtgtaxvalue.Name = "txtgtaxvalue";
            this.txtgtaxvalue.ReadOnly = true;
            this.txtgtaxvalue.Size = new System.Drawing.Size(115, 27);
            this.txtgtaxvalue.TabIndex = 44;
            // 
            // Calculatesalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 904);
            this.Controls.Add(this.txtgtaxvalue);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtgtax);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbemployeeID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "Calculatesalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculatesalary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbemployeeID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttripleot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnormalot;
        private System.Windows.Forms.TextBox txtdoubleot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttotalotvalue;
        private System.Windows.Forms.TextBox txtmonthlysalary;
        private System.Windows.Forms.TextBox txtallowances;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtotrate;
        private System.Windows.Forms.TextBox txttripleotvalue;
        private System.Windows.Forms.TextBox txtnormalotvalue;
        private System.Windows.Forms.TextBox txtdoubleotvalue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttotalworkingdays;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtnopayvalue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtabsentdays;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtgtax;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtgrosspay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdeductions;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbasepay;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtgtaxvalue;
    }
}