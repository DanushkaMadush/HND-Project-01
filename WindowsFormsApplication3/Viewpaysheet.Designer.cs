namespace WindowsFormsApplication3
{
    partial class Viewpaysheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewpaysheet));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtmonth = new System.Windows.Forms.TextBox();
            this.txtemployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnormalot = new System.Windows.Forms.TextBox();
            this.txttotalotvalue = new System.Windows.Forms.TextBox();
            this.txttripleot = new System.Windows.Forms.TextBox();
            this.txtdoubleot = new System.Windows.Forms.TextBox();
            this.txttripleotvalue = new System.Windows.Forms.TextBox();
            this.txtnormalotvalue = new System.Windows.Forms.TextBox();
            this.txtdoubleotvalue = new System.Windows.Forms.TextBox();
            this.txtallowances = new System.Windows.Forms.TextBox();
            this.txtmonthlysalary = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbasepayvalue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtgtax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnopayvalue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtgrosspay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtabsentdays = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(328, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 92);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtmonth
            // 
            this.txtmonth.CausesValidation = false;
            this.txtmonth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonth.Location = new System.Drawing.Point(99, 11);
            this.txtmonth.Name = "txtmonth";
            this.txtmonth.ReadOnly = true;
            this.txtmonth.Size = new System.Drawing.Size(223, 27);
            this.txtmonth.TabIndex = 29;
            this.txtmonth.TextChanged += new System.EventHandler(this.txtmonth_TextChanged);
            this.txtmonth.Leave += new System.EventHandler(this.txtmonth_Leave);
            // 
            // txtemployeeID
            // 
            this.txtemployeeID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeID.Location = new System.Drawing.Point(99, 44);
            this.txtemployeeID.Name = "txtemployeeID";
            this.txtemployeeID.ReadOnly = true;
            this.txtemployeeID.Size = new System.Drawing.Size(55, 27);
            this.txtemployeeID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "Paysheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Monthly Salary";
            // 
            // txtfname
            // 
            this.txtfname.CausesValidation = false;
            this.txtfname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(99, 77);
            this.txtfname.Name = "txtfname";
            this.txtfname.ReadOnly = true;
            this.txtfname.Size = new System.Drawing.Size(105, 27);
            this.txtfname.TabIndex = 31;
            // 
            // txtlname
            // 
            this.txtlname.CausesValidation = false;
            this.txtlname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(214, 77);
            this.txtlname.Name = "txtlname";
            this.txtlname.ReadOnly = true;
            this.txtlname.Size = new System.Drawing.Size(108, 27);
            this.txtlname.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Allowances";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Total OT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "Overtime-------------------------------------------------------------------------" +
    "-----------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Normal OT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(58, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Double OT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Triple OT";
            // 
            // txtnormalot
            // 
            this.txtnormalot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalot.Location = new System.Drawing.Point(164, 244);
            this.txtnormalot.Name = "txtnormalot";
            this.txtnormalot.ReadOnly = true;
            this.txtnormalot.Size = new System.Drawing.Size(55, 23);
            this.txtnormalot.TabIndex = 39;
            // 
            // txttotalotvalue
            // 
            this.txttotalotvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalotvalue.Location = new System.Drawing.Point(286, 326);
            this.txttotalotvalue.Name = "txttotalotvalue";
            this.txttotalotvalue.ReadOnly = true;
            this.txttotalotvalue.Size = new System.Drawing.Size(108, 23);
            this.txttotalotvalue.TabIndex = 40;
            // 
            // txttripleot
            // 
            this.txttripleot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttripleot.Location = new System.Drawing.Point(164, 290);
            this.txttripleot.Name = "txttripleot";
            this.txttripleot.ReadOnly = true;
            this.txttripleot.Size = new System.Drawing.Size(55, 23);
            this.txttripleot.TabIndex = 41;
            // 
            // txtdoubleot
            // 
            this.txtdoubleot.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoubleot.Location = new System.Drawing.Point(164, 267);
            this.txtdoubleot.Name = "txtdoubleot";
            this.txtdoubleot.ReadOnly = true;
            this.txtdoubleot.Size = new System.Drawing.Size(55, 23);
            this.txtdoubleot.TabIndex = 42;
            // 
            // txttripleotvalue
            // 
            this.txttripleotvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttripleotvalue.Location = new System.Drawing.Point(286, 290);
            this.txttripleotvalue.Name = "txttripleotvalue";
            this.txttripleotvalue.ReadOnly = true;
            this.txttripleotvalue.Size = new System.Drawing.Size(108, 23);
            this.txttripleotvalue.TabIndex = 44;
            // 
            // txtnormalotvalue
            // 
            this.txtnormalotvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalotvalue.Location = new System.Drawing.Point(286, 244);
            this.txtnormalotvalue.Name = "txtnormalotvalue";
            this.txtnormalotvalue.ReadOnly = true;
            this.txtnormalotvalue.Size = new System.Drawing.Size(108, 23);
            this.txtnormalotvalue.TabIndex = 45;
            // 
            // txtdoubleotvalue
            // 
            this.txtdoubleotvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoubleotvalue.Location = new System.Drawing.Point(286, 267);
            this.txtdoubleotvalue.Name = "txtdoubleotvalue";
            this.txtdoubleotvalue.ReadOnly = true;
            this.txtdoubleotvalue.Size = new System.Drawing.Size(108, 23);
            this.txtdoubleotvalue.TabIndex = 46;
            // 
            // txtallowances
            // 
            this.txtallowances.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtallowances.Location = new System.Drawing.Point(286, 190);
            this.txtallowances.Name = "txtallowances";
            this.txtallowances.ReadOnly = true;
            this.txtallowances.Size = new System.Drawing.Size(108, 23);
            this.txtallowances.TabIndex = 47;
            // 
            // txtmonthlysalary
            // 
            this.txtmonthlysalary.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonthlysalary.Location = new System.Drawing.Point(286, 167);
            this.txtmonthlysalary.Name = "txtmonthlysalary";
            this.txtmonthlysalary.ReadOnly = true;
            this.txtmonthlysalary.Size = new System.Drawing.Size(108, 23);
            this.txtmonthlysalary.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 14);
            this.label9.TabIndex = 49;
            this.label9.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // txtbasepayvalue
            // 
            this.txtbasepayvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbasepayvalue.Location = new System.Drawing.Point(286, 365);
            this.txtbasepayvalue.Name = "txtbasepayvalue";
            this.txtbasepayvalue.ReadOnly = true;
            this.txtbasepayvalue.Size = new System.Drawing.Size(108, 23);
            this.txtbasepayvalue.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 23);
            this.label10.TabIndex = 50;
            this.label10.Text = "Base Pay Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(412, 14);
            this.label11.TabIndex = 52;
            this.label11.Text = "Deductions-----------------------------------------------------------------------" +
    "---------------";
            // 
            // txtgtax
            // 
            this.txtgtax.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgtax.Location = new System.Drawing.Point(286, 443);
            this.txtgtax.Name = "txtgtax";
            this.txtgtax.ReadOnly = true;
            this.txtgtax.Size = new System.Drawing.Size(108, 23);
            this.txtgtax.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 23);
            this.label12.TabIndex = 53;
            this.label12.Text = "TAX";
            // 
            // txtnopayvalue
            // 
            this.txtnopayvalue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnopayvalue.Location = new System.Drawing.Point(286, 414);
            this.txtnopayvalue.Name = "txtnopayvalue";
            this.txtnopayvalue.ReadOnly = true;
            this.txtnopayvalue.Size = new System.Drawing.Size(108, 23);
            this.txtnopayvalue.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 414);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 23);
            this.label13.TabIndex = 55;
            this.label13.Text = "No Pay Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(411, 14);
            this.label14.TabIndex = 57;
            this.label14.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // txtgrosspay
            // 
            this.txtgrosspay.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrosspay.Location = new System.Drawing.Point(286, 492);
            this.txtgrosspay.Name = "txtgrosspay";
            this.txtgrosspay.ReadOnly = true;
            this.txtgrosspay.Size = new System.Drawing.Size(108, 26);
            this.txtgrosspay.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 492);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 26);
            this.label15.TabIndex = 58;
            this.label15.Text = "Gross Pay";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(9, 527);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(411, 14);
            this.label16.TabIndex = 60;
            this.label16.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // txtabsentdays
            // 
            this.txtabsentdays.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabsentdays.Location = new System.Drawing.Point(164, 414);
            this.txtabsentdays.Name = "txtabsentdays";
            this.txtabsentdays.ReadOnly = true;
            this.txtabsentdays.Size = new System.Drawing.Size(55, 23);
            this.txtabsentdays.TabIndex = 61;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(205, 584);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(104, 40);
            this.btnback.TabIndex = 62;
            this.btnback.Text = "<<Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnprint
            // 
            this.btnprint.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(320, 584);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(104, 40);
            this.btnprint.TabIndex = 63;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(257, 170);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 15);
            this.label17.TabIndex = 64;
            this.label17.Text = "Rs.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(257, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 15);
            this.label18.TabIndex = 65;
            this.label18.Text = "Rs.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(257, 250);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 15);
            this.label19.TabIndex = 66;
            this.label19.Text = "Rs.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(257, 270);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 15);
            this.label20.TabIndex = 67;
            this.label20.Text = "Rs.";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(257, 293);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 15);
            this.label21.TabIndex = 68;
            this.label21.Text = "Rs.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(257, 329);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 15);
            this.label22.TabIndex = 69;
            this.label22.Text = "Rs.";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(257, 368);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 15);
            this.label23.TabIndex = 70;
            this.label23.Text = "Rs.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(257, 420);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 15);
            this.label24.TabIndex = 71;
            this.label24.Text = "Rs.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(257, 449);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(23, 15);
            this.label25.TabIndex = 72;
            this.label25.Text = "Rs.";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(257, 497);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 15);
            this.label26.TabIndex = 73;
            this.label26.Text = "Rs.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(219, 249);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(26, 15);
            this.label27.TabIndex = 74;
            this.label27.Text = "Hrs";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(219, 270);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 15);
            this.label28.TabIndex = 75;
            this.label28.Text = "Hrs";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(219, 293);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 15);
            this.label29.TabIndex = 76;
            this.label29.Text = "Hrs";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(219, 420);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(34, 15);
            this.label30.TabIndex = 77;
            this.label30.Text = "Days";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(10, 141);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(411, 14);
            this.label31.TabIndex = 78;
            this.label31.Text = "---------------------------------------------------------------------------------" +
    "--------------------";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 78);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 26);
            this.label32.TabIndex = 79;
            this.label32.Text = "Name";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(8, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 26);
            this.label33.TabIndex = 80;
            this.label33.Text = "E NO";
            // 
            // Viewpaysheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 647);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtabsentdays);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtgrosspay);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtnopayvalue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtgtax);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbasepayvalue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmonthlysalary);
            this.Controls.Add(this.txtallowances);
            this.Controls.Add(this.txtdoubleotvalue);
            this.Controls.Add(this.txtnormalotvalue);
            this.Controls.Add(this.txttripleotvalue);
            this.Controls.Add(this.txtdoubleot);
            this.Controls.Add(this.txttripleot);
            this.Controls.Add(this.txttotalotvalue);
            this.Controls.Add(this.txtnormalot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.txtmonth);
            this.Controls.Add(this.txtemployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Viewpaysheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viewpaysheet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtmonth;
        private System.Windows.Forms.TextBox txtemployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtnormalot;
        private System.Windows.Forms.TextBox txttotalotvalue;
        private System.Windows.Forms.TextBox txttripleot;
        private System.Windows.Forms.TextBox txtdoubleot;
        private System.Windows.Forms.TextBox txttripleotvalue;
        private System.Windows.Forms.TextBox txtnormalotvalue;
        private System.Windows.Forms.TextBox txtdoubleotvalue;
        private System.Windows.Forms.TextBox txtallowances;
        private System.Windows.Forms.TextBox txtmonthlysalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbasepayvalue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtgtax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnopayvalue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtgrosspay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtabsentdays;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
    }
}