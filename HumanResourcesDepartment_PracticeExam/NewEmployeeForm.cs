using HumanResourcesDepartment_PracticeExam.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResourcesDepartment_PracticeExam
{
    public partial class NewEmployeeForm : Form
    {
        #region Attributes & Properties
        public static long Id = 0;
        public Employee Employee { get; set; }
        #endregion
        public NewEmployeeForm()
        {
            InitializeComponent();
            DisplayDepartments();
        }

        public NewEmployeeForm(Employee employee)
        {
            InitializeComponent();
            DisplayDepartments();
            Employee = employee;
        }
        #region Methods

        void DisplayDepartments()
        {
            foreach(Department department in MainForm.departments)
            {
                cbDepartment.Items.Add(department.Name);
            }
        }

        void AddEmployee()
        {
            
            if (!ValidateChildren())
            {
                MessageBox.Show(
                    "Invalid data. Check again",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (Employee == null)
            {
                Employee employee = new Employee();
                //provizoriu un id
                employee.Id = ++Id;
                employee.BirthDate = dtpBirthDate.Value;
                employee.Name = tbName.Text;
                employee.Wage = int.Parse(tbWage.Text);
                if (cbDepartment.SelectedIndex == -1)
                {
                    employee.IdDepartment = 0;
                }
                else
                {
                    foreach (Department department in MainForm.departments)
                    {
                        if (cbDepartment.Text == department.Name)
                        {
                            employee.IdDepartment = department.Id;
                        }
                    }
                }
                MainForm.employees.Add(employee);
            }
            else
            {


                Employee.BirthDate = dtpBirthDate.Value;
                Employee.Name = tbName.Text;
                Employee.Wage = int.Parse(tbWage.Text);
                if (cbDepartment.SelectedIndex == -1)
                {
                    Employee.IdDepartment = 0;
                }
                else
                {
                    foreach (Department department in MainForm.departments)
                    {
                        if (cbDepartment.Text == department.Name)
                        {
                            Employee.IdDepartment = department.Id;
                        }
                    }
                }
            }
        }

        #endregion





        #region Events
        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            if (Employee != null)
            {
                tbName.Text = Employee.Name;
                dtpBirthDate.Value = Employee.BirthDate;
                tbWage.Text = Employee.Wage.ToString();
                if (Employee.IdDepartment == 0)
                {
                    cbDepartment.SelectedIndex = -1;
                }
                else
                {
                    foreach (Department department in MainForm.departments)
                    {
                        if (Employee.IdDepartment == department.Id)
                        {
                            cbDepartment.SelectedItem = department.Name;
                        }
                    }
                }
            }
        }

        

        private void dtpBirthDate_Validating(object sender, CancelEventArgs e)
        {
            // chosen date - current date = minimum of 16 years

            DateTime sixteen = new DateTime(DateTime.Now.Year - 16, DateTime.Now.Month, DateTime.Now.Day);
            DateTime oneHundred = new DateTime(DateTime.Now.Year - 100, DateTime.Now.Month, DateTime.Now.Day);
            if (dtpBirthDate.Value.Date > sixteen)
            {
                errorProvider.SetError(dtpBirthDate, "Employee must be at least 16 years old");
                e.Cancel = true;
            }
            if (dtpBirthDate.Value.Date < oneHundred)
            {
                errorProvider.SetError(dtpBirthDate, "Employee can't be over 100 years old");
                e.Cancel = true;
            }
        }

        private void dtpBirthDate_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(dtpBirthDate, null);
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length < 3)
            {
                errorProvider.SetError(tbName, "Name must have at least 3 characters");
                e.Cancel = true;
            }
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbName, null);
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void tbWage_Validating(object sender, CancelEventArgs e)
        {
            if (tbWage.Text.Length <= 0)
            {
                errorProvider.SetError(tbWage, "Must provide wage");
                e.Cancel = true;
            }
            else if (int.Parse(tbWage.Text) < 0) // not mandatory
            {
                errorProvider.SetError(tbWage, "Wage must be at least 0");
                e.Cancel = true;
            }
        }

        private void tbWage_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(tbWage, null);
        }

        private void tbWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee();
            this.Close();
        }

        #endregion
    }
}
