
namespace HumanResourcesDepartment_PracticeExam
{
    partial class NewEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbWage = new System.Windows.Forms.TextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(410, 188);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(473, 38);
            this.tbName.TabIndex = 4;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbName_KeyPress);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(410, 301);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(473, 38);
            this.dtpBirthDate.TabIndex = 5;
            this.dtpBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBirthDate_Validating);
            this.dtpBirthDate.Validated += new System.EventHandler(this.dtpBirthDate_Validated);
            // 
            // tbWage
            // 
            this.tbWage.Location = new System.Drawing.Point(410, 408);
            this.tbWage.Name = "tbWage";
            this.tbWage.Size = new System.Drawing.Size(100, 38);
            this.tbWage.TabIndex = 6;
            this.tbWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWage_KeyPress);
            this.tbWage.Validating += new System.ComponentModel.CancelEventHandler(this.tbWage_Validating);
            this.tbWage.Validated += new System.EventHandler(this.tbWage_Validated);
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(410, 527);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(309, 39);
            this.cbDepartment.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddEmployee.Location = new System.Drawing.Point(410, 689);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(285, 78);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "OK";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1119, 857);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.tbWage);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox tbWage;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnAddEmployee;
    }
}