namespace WindowsFormsApplication3
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOvertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateOvertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaysheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.salaryToolStripMenuItem,
            this.salaryToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthToolStripMenuItem,
            this.leaveToolStripMenuItem});
            this.salaryToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.salaryToolStripMenuItem.Text = "Setting";
            // 
            // monthToolStripMenuItem
            // 
            this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
            this.monthToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monthToolStripMenuItem.Text = "Month";
            this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
            // 
            // leaveToolStripMenuItem
            // 
            this.leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            this.leaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.leaveToolStripMenuItem.Text = "Leave";
            this.leaveToolStripMenuItem.Click += new System.EventHandler(this.leaveToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem1
            // 
            this.salaryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOTToolStripMenuItem,
            this.calculateSalaryToolStripMenuItem,
            this.viewPaysheetToolStripMenuItem});
            this.salaryToolStripMenuItem1.Name = "salaryToolStripMenuItem1";
            this.salaryToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.salaryToolStripMenuItem1.Text = "Salary";
            // 
            // addOTToolStripMenuItem
            // 
            this.addOTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOvertimeToolStripMenuItem,
            this.calculateOvertimeToolStripMenuItem});
            this.addOTToolStripMenuItem.Name = "addOTToolStripMenuItem";
            this.addOTToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addOTToolStripMenuItem.Text = "OverTime";
            // 
            // addOvertimeToolStripMenuItem
            // 
            this.addOvertimeToolStripMenuItem.Name = "addOvertimeToolStripMenuItem";
            this.addOvertimeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.addOvertimeToolStripMenuItem.Text = "Add Overtime";
            this.addOvertimeToolStripMenuItem.Click += new System.EventHandler(this.addOvertimeToolStripMenuItem_Click);
            // 
            // calculateOvertimeToolStripMenuItem
            // 
            this.calculateOvertimeToolStripMenuItem.Name = "calculateOvertimeToolStripMenuItem";
            this.calculateOvertimeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.calculateOvertimeToolStripMenuItem.Text = "Calculate Overtime";
            this.calculateOvertimeToolStripMenuItem.Click += new System.EventHandler(this.calculateOvertimeToolStripMenuItem_Click);
            // 
            // calculateSalaryToolStripMenuItem
            // 
            this.calculateSalaryToolStripMenuItem.Name = "calculateSalaryToolStripMenuItem";
            this.calculateSalaryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.calculateSalaryToolStripMenuItem.Text = "Calculate Salary";
            this.calculateSalaryToolStripMenuItem.Click += new System.EventHandler(this.calculateSalaryToolStripMenuItem_Click);
            // 
            // viewPaysheetToolStripMenuItem
            // 
            this.viewPaysheetToolStripMenuItem.Name = "viewPaysheetToolStripMenuItem";
            this.viewPaysheetToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewPaysheetToolStripMenuItem.Text = "View Paysheet";
            this.viewPaysheetToolStripMenuItem.Click += new System.EventHandler(this.viewPaysheetToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1850, 821);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaysheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOvertimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateOvertimeToolStripMenuItem;
    }
}