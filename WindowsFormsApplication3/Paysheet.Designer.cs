namespace WindowsFormsApplication3
{
    partial class Paysheet
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
            this.cmbemployeeID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbmonth = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnviewpaysheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(826, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 42);
            this.label9.TabIndex = 36;
            this.label9.Text = "Paysheet";
            // 
            // cmbemployeeID
            // 
            this.cmbemployeeID.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemployeeID.FormattingEnabled = true;
            this.cmbemployeeID.Location = new System.Drawing.Point(879, 285);
            this.cmbemployeeID.Name = "cmbemployeeID";
            this.cmbemployeeID.Size = new System.Drawing.Size(124, 31);
            this.cmbemployeeID.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(694, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 26);
            this.label10.TabIndex = 37;
            this.label10.Text = "Employee ID";
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
            this.cmbmonth.Location = new System.Drawing.Point(879, 336);
            this.cmbmonth.Name = "cmbmonth";
            this.cmbmonth.Size = new System.Drawing.Size(224, 31);
            this.cmbmonth.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(697, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 26);
            this.label12.TabIndex = 39;
            this.label12.Text = "Month";
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(762, 436);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 40);
            this.btnhome.TabIndex = 43;
            this.btnhome.Text = "<<Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(872, 436);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 40);
            this.btnclear.TabIndex = 42;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnviewpaysheet
            // 
            this.btnviewpaysheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnviewpaysheet.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewpaysheet.Location = new System.Drawing.Point(982, 436);
            this.btnviewpaysheet.Name = "btnviewpaysheet";
            this.btnviewpaysheet.Size = new System.Drawing.Size(148, 40);
            this.btnviewpaysheet.TabIndex = 44;
            this.btnviewpaysheet.Text = "View Paysheet";
            this.btnviewpaysheet.UseVisualStyleBackColor = false;
            this.btnviewpaysheet.Click += new System.EventHandler(this.btnviewpaysheet_Click);
            // 
            // Paysheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 892);
            this.Controls.Add(this.btnviewpaysheet);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.cmbmonth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbemployeeID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "Paysheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paysheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbemployeeID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbmonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnviewpaysheet;
    }
}