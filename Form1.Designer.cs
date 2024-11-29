namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Employees = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.CountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.AllowUserToAddRows = false;
            this.Employees.AllowUserToDeleteRows = false;
            this.Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.Time,
            this._Bonus,
            this._Fine});
            this.Employees.Location = new System.Drawing.Point(12, 31);
            this.Employees.Name = "Employees";
            this.Employees.ReadOnly = true;
            this.Employees.RowHeadersWidth = 51;
            this.Employees.RowTemplate.Height = 29;
            this.Employees.Size = new System.Drawing.Size(776, 320);
            this.Employees.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 6;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.Width = 320;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // _Bonus
            // 
            this._Bonus.HeaderText = "Bonus";
            this._Bonus.MinimumWidth = 6;
            this._Bonus.Name = "_Bonus";
            this._Bonus.ReadOnly = true;
            this._Bonus.Width = 125;
            // 
            // _Fine
            // 
            this._Fine.HeaderText = "Fine";
            this._Fine.MinimumWidth = 6;
            this._Fine.Name = "_Fine";
            this._Fine.ReadOnly = true;
            this._Fine.Width = 125;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFromxmlToolStripMenuItem,
            this.saveAsxmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFromxmlToolStripMenuItem
            // 
            this.openFromxmlToolStripMenuItem.Image = global::WinFormsApp1.Properties.Resources.open1;
            this.openFromxmlToolStripMenuItem.Name = "openFromxmlToolStripMenuItem";
            this.openFromxmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFromxmlToolStripMenuItem.Text = "Open from .xml...";
            this.openFromxmlToolStripMenuItem.Click += new System.EventHandler(this.openFromxmlToolStripMenuItem_Click);
            // 
            // saveAsxmlToolStripMenuItem
            // 
            this.saveAsxmlToolStripMenuItem.Image = global::WinFormsApp1.Properties.Resources.save;
            this.saveAsxmlToolStripMenuItem.Name = "saveAsxmlToolStripMenuItem";
            this.saveAsxmlToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsxmlToolStripMenuItem.Text = "Save as .xml ...";
            this.saveAsxmlToolStripMenuItem.Click += new System.EventHandler(this.saveAsxmlToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem
            // 
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem.Image = global::WinFormsApp1.Properties.Resources.report;
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem.Name = "generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem";
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem.Size = new System.Drawing.Size(461, 26);
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem.Text = "Generate report about bonuses and fines for employees";
            this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem.Click += new System.EventHandler(this.generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Image = global::WinFormsApp1.Properties.Resources.about;
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // CountButton
            // 
            this.CountButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountButton.Location = new System.Drawing.Point(277, 367);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(259, 71);
            this.CountButton.TabIndex = 2;
            this.CountButton.Text = "Count bonuses and fines for employees";
            this.CountButton.UseVisualStyleBackColor = false;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView Employees;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFromxmlToolStripMenuItem;
        private ToolStripMenuItem saveAsxmlToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem generateReportAboutBonusesAndFinesForEmployeesToolStripMenuItem;
        private SaveFileDialog saveFileDialog2;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn _Bonus;
        private DataGridViewTextBoxColumn _Fine;
        private Button CountButton;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}