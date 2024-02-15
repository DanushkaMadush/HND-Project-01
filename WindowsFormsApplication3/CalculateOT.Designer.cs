namespace WindowsFormsApplication3
{
    partial class CalculateOT
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbemployeeID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtotrate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnormalot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdoubleot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttripleot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncalulate = new System.Windows.Forms.Button();
            this.txttriplevalue = new System.Windows.Forms.TextBox();
            this.txtdoublevalue = new System.Windows.Forms.TextBox();
            this.txtnormalvalue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overtime Calculation Form";
            // 
            // cmbemployeeID
            // 
            this.cmbemployeeID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemployeeID.FormattingEnabled = true;
            this.cmbemployeeID.Location = new System.Drawing.Point(795, 131);
            this.cmbemployeeID.Name = "cmbemployeeID";
            this.cmbemployeeID.Size = new System.Drawing.Size(322, 31);
            this.cmbemployeeID.TabIndex = 30;
            this.cmbemployeeID.Leave += new System.EventHandler(this.cmbemployeeID_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 29;
            this.label5.Text = "Employee ID";
            // 
            // txtotrate
            // 
            this.txtotrate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotrate.Location = new System.Drawing.Point(795, 189);
            this.txtotrate.Name = "txtotrate";
            this.txtotrate.Size = new System.Drawing.Size(322, 31);
            this.txtotrate.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Overtime Rate";
            // 
            // datefrom
            // 
            this.datefrom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefrom.Location = new System.Drawing.Point(795, 306);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(322, 31);
            this.datefrom.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "From";
            // 
            // dateto
            // 
            this.dateto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateto.Location = new System.Drawing.Point(795, 365);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(322, 31);
            this.dateto.TabIndex = 36;
            this.dateto.Leave += new System.EventHandler(this.dateto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(474, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "To";
            // 
            // txtnormalot
            // 
            this.txtnormalot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalot.Location = new System.Drawing.Point(795, 426);
            this.txtnormalot.Name = "txtnormalot";
            this.txtnormalot.Size = new System.Drawing.Size(88, 31);
            this.txtnormalot.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 26);
            this.label6.TabIndex = 37;
            this.label6.Text = "Normal Overtime";
            // 
            // txtdoubleot
            // 
            this.txtdoubleot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoubleot.Location = new System.Drawing.Point(795, 486);
            this.txtdoubleot.Name = "txtdoubleot";
            this.txtdoubleot.Size = new System.Drawing.Size(88, 31);
            this.txtdoubleot.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(474, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 26);
            this.label7.TabIndex = 39;
            this.label7.Text = "Double Overtime";
            // 
            // txttripleot
            // 
            this.txttripleot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttripleot.Location = new System.Drawing.Point(795, 546);
            this.txttripleot.Name = "txttripleot";
            this.txttripleot.Size = new System.Drawing.Size(88, 31);
            this.txttripleot.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(474, 551);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 26);
            this.label8.TabIndex = 41;
            this.label8.Text = "Triple Overtime";
            // 
            // btncalulate
            // 
            this.btncalulate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalulate.Location = new System.Drawing.Point(906, 480);
            this.btncalulate.Name = "btncalulate";
            this.btncalulate.Size = new System.Drawing.Size(104, 40);
            this.btncalulate.TabIndex = 43;
            this.btncalulate.Text = "Calculate";
            this.btncalulate.UseVisualStyleBackColor = true;
            this.btncalulate.Click += new System.EventHandler(this.btncalulate_Click);
            // 
            // txttriplevalue
            // 
            this.txttriplevalue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttriplevalue.Location = new System.Drawing.Point(1029, 546);
            this.txttriplevalue.Name = "txttriplevalue";
            this.txttriplevalue.Size = new System.Drawing.Size(88, 31);
            this.txttriplevalue.TabIndex = 46;
            // 
            // txtdoublevalue
            // 
            this.txtdoublevalue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoublevalue.Location = new System.Drawing.Point(1029, 486);
            this.txtdoublevalue.Name = "txtdoublevalue";
            this.txtdoublevalue.Size = new System.Drawing.Size(88, 31);
            this.txtdoublevalue.TabIndex = 45;
            // 
            // txtnormalvalue
            // 
            this.txtnormalvalue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalvalue.Location = new System.Drawing.Point(1029, 426);
            this.txtnormalvalue.Name = "txtnormalvalue";
            this.txtnormalvalue.Size = new System.Drawing.Size(88, 31);
            this.txtnormalvalue.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(817, 676);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 26);
            this.label9.TabIndex = 47;
            this.label9.Text = "Total Overtime Value";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(1029, 676);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(88, 31);
            this.txttotal.TabIndex = 48;
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(1328, 803);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 40);
            this.btnhome.TabIndex = 51;
            this.btnhome.Text = "<<Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(1438, 803);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 40);
            this.btnclear.TabIndex = 50;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(1548, 803);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 40);
            this.btnsave.TabIndex = 49;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(474, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 26);
            this.label10.TabIndex = 52;
            this.label10.Text = "Month";
            // 
            // cmbmonth
            // 
            this.cmbmonth.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbmonth.Location = new System.Drawing.Point(795, 247);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(322, 31);
            this.cmbmonth.TabIndex = 53;
            this.cmbmonth.Leave += new System.EventHandler(this.cmbmonth_Leave);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(1658, 803);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 40);
            this.btnupdate.TabIndex = 54;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // CalculateOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 902);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txttriplevalue);
            this.Controls.Add(this.txtdoublevalue);
            this.Controls.Add(this.txtnormalvalue);
            this.Controls.Add(this.btncalulate);
            this.Controls.Add(this.txttripleot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdoubleot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtnormalot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datefrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtotrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbemployeeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "CalculateOT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculateOT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalculateOT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbemployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtotrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnormalot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdoubleot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttripleot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncalulate;
        private System.Windows.Forms.TextBox txttriplevalue;
        private System.Windows.Forms.TextBox txtdoublevalue;
        private System.Windows.Forms.TextBox txtnormalvalue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.Button btnupdate;
    }
}