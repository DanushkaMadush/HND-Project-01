namespace WindowsFormsApplication3
{
    partial class Month
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateRange = new System.Windows.Forms.TextBox();
            this.txtHolidays = new System.Windows.Forms.TextBox();
            this.monthEndDate = new System.Windows.Forms.DateTimePicker();
            this.monthStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.txttotalworkingdays = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(706, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(537, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Holidays";
            // 
            // txtDateRange
            // 
            this.txtDateRange.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRange.Location = new System.Drawing.Point(833, 355);
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.Size = new System.Drawing.Size(303, 31);
            this.txtDateRange.TabIndex = 8;
            // 
            // txtHolidays
            // 
            this.txtHolidays.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHolidays.Location = new System.Drawing.Point(833, 424);
            this.txtHolidays.Name = "txtHolidays";
            this.txtHolidays.Size = new System.Drawing.Size(303, 31);
            this.txtHolidays.TabIndex = 9;
            this.txtHolidays.Leave += new System.EventHandler(this.txtHolidays_Leave);
            // 
            // monthEndDate
            // 
            this.monthEndDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthEndDate.Location = new System.Drawing.Point(833, 297);
            this.monthEndDate.Name = "monthEndDate";
            this.monthEndDate.Size = new System.Drawing.Size(303, 31);
            this.monthEndDate.TabIndex = 10;
            // 
            // monthStartDate
            // 
            this.monthStartDate.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthStartDate.Location = new System.Drawing.Point(833, 236);
            this.monthStartDate.Name = "monthStartDate";
            this.monthStartDate.Size = new System.Drawing.Size(303, 31);
            this.monthStartDate.TabIndex = 11;
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
            this.cmbmonth.Location = new System.Drawing.Point(833, 178);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(303, 31);
            this.cmbmonth.TabIndex = 12;
            this.cmbmonth.Leave += new System.EventHandler(this.cmbmonth_Leave);
            // 
            // txttotalworkingdays
            // 
            this.txttotalworkingdays.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalworkingdays.Location = new System.Drawing.Point(833, 493);
            this.txttotalworkingdays.Name = "txttotalworkingdays";
            this.txttotalworkingdays.Size = new System.Drawing.Size(303, 31);
            this.txttotalworkingdays.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Working Days";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(932, 652);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(104, 40);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(822, 652);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 40);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(712, 652);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 40);
            this.btnhome.TabIndex = 17;
            this.btnhome.Text = "<<Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1859, 884);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttotalworkingdays);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.monthStartDate);
            this.Controls.Add(this.monthEndDate);
            this.Controls.Add(this.txtHolidays);
            this.Controls.Add(this.txtDateRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Month";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Month";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateRange;
        private System.Windows.Forms.TextBox txtHolidays;
        private System.Windows.Forms.DateTimePicker monthEndDate;
        private System.Windows.Forms.DateTimePicker monthStartDate;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.TextBox txttotalworkingdays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnhome;
    }
}