namespace WindowsFormsApplication3
{
    partial class UpdateOT
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtnormalot = new System.Windows.Forms.TextBox();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.cmbemployeeid = new System.Windows.Forms.ComboBox();
            this.dateot = new System.Windows.Forms.DateTimePicker();
            this.txttripleot = new System.Windows.Forms.TextBox();
            this.txtdoubleot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(409, 500);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(104, 40);
            this.btnupdate.TabIndex = 50;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // txtnormalot
            // 
            this.txtnormalot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormalot.Location = new System.Drawing.Point(289, 255);
            this.txtnormalot.Name = "txtnormalot";
            this.txtnormalot.Size = new System.Drawing.Size(303, 31);
            this.txtnormalot.TabIndex = 49;
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(189, 500);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(104, 40);
            this.btnhome.TabIndex = 48;
            this.btnhome.Text = "<<Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(299, 500);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(104, 40);
            this.btnclear.TabIndex = 47;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // cmbemployeeid
            // 
            this.cmbemployeeid.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemployeeid.FormattingEnabled = true;
            this.cmbemployeeid.Location = new System.Drawing.Point(289, 141);
            this.cmbemployeeid.Name = "cmbemployeeid";
            this.cmbemployeeid.Size = new System.Drawing.Size(303, 31);
            this.cmbemployeeid.TabIndex = 45;
            // 
            // dateot
            // 
            this.dateot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateot.Location = new System.Drawing.Point(289, 199);
            this.dateot.Name = "dateot";
            this.dateot.Size = new System.Drawing.Size(303, 31);
            this.dateot.TabIndex = 44;
            this.dateot.Leave += new System.EventHandler(this.dateot_Leave);
            // 
            // txttripleot
            // 
            this.txttripleot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttripleot.Location = new System.Drawing.Point(289, 387);
            this.txttripleot.Name = "txttripleot";
            this.txttripleot.Size = new System.Drawing.Size(303, 31);
            this.txttripleot.TabIndex = 43;
            // 
            // txtdoubleot
            // 
            this.txtdoubleot.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoubleot.Location = new System.Drawing.Point(289, 318);
            this.txtdoubleot.Name = "txtdoubleot";
            this.txtdoubleot.Size = new System.Drawing.Size(303, 31);
            this.txtdoubleot.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Triple Overtime Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 26);
            this.label5.TabIndex = 40;
            this.label5.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Overtime Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Double Overtime Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Edit Overtime Details";
            // 
            // UpdateOT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 637);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtnormalot);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.cmbemployeeid);
            this.Controls.Add(this.dateot);
            this.Controls.Add(this.txttripleot);
            this.Controls.Add(this.txtdoubleot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateOT";
            this.Text = "UpdateOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtnormalot;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox cmbemployeeid;
        private System.Windows.Forms.DateTimePicker dateot;
        private System.Windows.Forms.TextBox txttripleot;
        private System.Windows.Forms.TextBox txtdoubleot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}