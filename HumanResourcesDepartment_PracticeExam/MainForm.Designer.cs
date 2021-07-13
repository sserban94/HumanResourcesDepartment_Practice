
namespace HumanResourcesDepartment_PracticeExam
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSortAscName = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSortDescBirthDate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnCheckEmployeesDepartment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEraseDb = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnExportXML = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImportXML = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.Location = new System.Drawing.Point(1087, 786);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(278, 83);
            this.btnAddEmployee.TabIndex = 0;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvEmployees.ContextMenuStrip = this.contextMenuStrip;
            this.dgvEmployees.Location = new System.Drawing.Point(80, 248);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 102;
            this.dgvEmployees.RowTemplate.Height = 40;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1652, 503);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellDoubleClick);
            this.dgvEmployees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvEmployees_KeyPress);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee Id";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birth Date";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Wage";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Department Id";
            this.Column5.MinimumWidth = 12;
            this.Column5.Name = "Column5";
            this.Column5.Width = 250;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(151, 52);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSortAscName,
            this.btnSortDescBirthDate});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(150, 48);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // btnSortAscName
            // 
            this.btnSortAscName.Name = "btnSortAscName";
            this.btnSortAscName.Size = new System.Drawing.Size(521, 54);
            this.btnSortAscName.Text = "Ascending by Name";
            this.btnSortAscName.Click += new System.EventHandler(this.btnSortAscName_Click);
            // 
            // btnSortDescBirthDate
            // 
            this.btnSortDescBirthDate.Name = "btnSortDescBirthDate";
            this.btnSortDescBirthDate.Size = new System.Drawing.Size(521, 54);
            this.btnSortDescBirthDate.Text = "Descending by Birth Date";
            this.btnSortDescBirthDate.Click += new System.EventHandler(this.btnSortDescBirthDate_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEmployee.Location = new System.Drawing.Point(1389, 786);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(266, 83);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnCheckEmployeesDepartment
            // 
            this.btnCheckEmployeesDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckEmployeesDepartment.Location = new System.Drawing.Point(80, 855);
            this.btnCheckEmployeesDepartment.Name = "btnCheckEmployeesDepartment";
            this.btnCheckEmployeesDepartment.Size = new System.Drawing.Size(289, 83);
            this.btnCheckEmployeesDepartment.TabIndex = 3;
            this.btnCheckEmployeesDepartment.Text = "Check All";
            this.btnCheckEmployeesDepartment.UseVisualStyleBackColor = true;
            this.btnCheckEmployeesDepartment.Click += new System.EventHandler(this.btnCheckEmployeesDepartment_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 812);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Check if all employees are associated with a department";
            // 
            // btnEraseDb
            // 
            this.btnEraseDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEraseDb.Location = new System.Drawing.Point(1603, 167);
            this.btnEraseDb.Name = "btnEraseDb";
            this.btnEraseDb.Size = new System.Drawing.Size(232, 60);
            this.btnEraseDb.TabIndex = 5;
            this.btnEraseDb.Text = "Erase DB";
            this.btnEraseDb.UseVisualStyleBackColor = true;
            this.btnEraseDb.Click += new System.EventHandler(this.btnEraseDb_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1870, 51);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton
            // 
            this.toolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExportXML,
            this.btnImportXML});
            this.toolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton.Image")));
            this.toolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton.Name = "toolStripDropDownButton";
            this.toolStripDropDownButton.Size = new System.Drawing.Size(66, 44);
            this.toolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // btnExportXML
            // 
            this.btnExportXML.Name = "btnExportXML";
            this.btnExportXML.Size = new System.Drawing.Size(412, 54);
            this.btnExportXML.Text = "Export to XML";
            this.btnExportXML.Click += new System.EventHandler(this.btnExportXML_Click);
            // 
            // btnImportXML
            // 
            this.btnImportXML.Name = "btnImportXML";
            this.btnImportXML.Size = new System.Drawing.Size(412, 54);
            this.btnImportXML.Text = "Import from XML";
            this.btnImportXML.Click += new System.EventHandler(this.btnImportXML_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1870, 986);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnEraseDb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckEmployeesDepartment);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnCheckEmployeesDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEraseDb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSortAscName;
        private System.Windows.Forms.ToolStripMenuItem btnSortDescBirthDate;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem btnExportXML;
        private System.Windows.Forms.ToolStripMenuItem btnImportXML;
    }
}

