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
using Microsoft.Data.Sqlite;
using System.Xml.Serialization;
using System.IO;

namespace HumanResourcesDepartment_PracticeExam
{
    public partial class MainForm : Form
    {
        #region Attributes + Properties

        public static List<Department> departments;
        public static List<Employee> employees;
        public static string stringConnection = "data source=employees.db";

        #endregion
        public MainForm()
        {
            InitializeComponent();
            departments = new List<Department>();
            Department d1 = new Department(1, "Legal");
            Department d2 = new Department(2, "Human Resources");
            Department d3 = new Department(3, "Sales");
            Department d4 = new Department(4, "Tech");

            departments.Add(d1);
            departments.Add(d2);
            departments.Add(d3);
            departments.Add(d4);
            employees = new List<Employee>();

        }

        #region Methods
        public void DisplayEmployees()
        {
            dgvEmployees.Rows.Clear();
            foreach (Employee employee in employees)
            {

                // Complicated variant
                //DataGridViewRow row = new DataGridViewRow();
                //row.Cells[0].Value = employee.Id;
                //row.Cells[1].Value = employee.Name;
                //row.Cells[2].Value = employee.BirthDate;
                //row.Cells[3].Value = employee.Wage;
                //row.Cells[4].Value = employee.IdDepartment;
                //row.Tag = employee;
                //dgvEmployees.Rows.Add(row);

                int rowIndex = dgvEmployees.Rows.Add(
                    new object[]
                    {
                        employee.Id,
                        employee.Name,
                        employee.BirthDate.ToShortDateString(),
                        employee.Wage,
                        employee.IdDepartment
                    });
                dgvEmployees.Rows[rowIndex].Tag = employee;
            }

        }

        private void DeleteEmployees()
        {
            DeleteFromSQL();
            foreach (DataGridViewRow row in dgvEmployees.SelectedRows)
            {
                Employee employee = (Employee)row.Tag;
                employees.Remove(employee);
            }
            DisplayEmployees();
        }

        private void EditEmployee()
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select row");
            }
            Employee employee = (Employee)dgvEmployees.SelectedRows[0].Tag;
            NewEmployeeForm nef = new NewEmployeeForm(employee);
            nef.ShowDialog();
            DisplayEmployees();
        }

        private void CheckEmployeesDepartments()
        {
            int trueCount = 0;
            foreach (Employee employee in employees)
            {
                if ((bool)employee) { trueCount++; }
            }
            if (trueCount == employees.Count)
            {
                MessageBox.Show("All employees are associated with a department");
            }
            else
            {
                MessageBox.Show("There are employees which are not associated with a department");
            }
        }

        void ImportFromSQL()
        {

            // write the select query
            string query = "SELECT * FROM Employees";

            // create an object of type SqliteConnection

            using (SqliteConnection connection = new SqliteConnection(stringConnection))
            {
                // create sql command with the query
                SqliteCommand command = new SqliteCommand(query, connection);
                // open connection now
                connection.Open();
                // get data from db
                SqliteDataReader reader = command.ExecuteReader();
                // while there are rows
                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = (long)reader["Id"];
                    employee.Name = reader["Name"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
                    employee.Wage = int.Parse(reader["Wage"].ToString());
                    employee.IdDepartment = int.Parse(reader["IdDepartment"].ToString());
                    employees.Add(employee);
                }

            }
        }

        void ExportToSQL()
        {
            string query = "INSERT INTO Employees (Id, Name, BirthDate, Wage, IdDepartment) VALUES " +
            "(@Id, @Name, @BirthDate, @Wage, @IdDepartment);";
            foreach (Employee employee in employees)
            {
                using (SqliteConnection connection = new SqliteConnection(stringConnection))
                {
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", employee.Id);
                    command.Parameters.AddWithValue("@Name", employee.Name);
                    command.Parameters.AddWithValue("@BirthDate", employee.BirthDate);
                    command.Parameters.AddWithValue("@Wage", employee.Wage);
                    command.Parameters.AddWithValue("@IdDepartment", employee.IdDepartment);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        void DeleteEverythingFromSQL()  // doesn't work
        {
            string query = "DELETE FROM Employees";
            using (SqliteConnection connection = new SqliteConnection(stringConnection))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        void DeleteFromSQL()
        {
            string query = "DELETE FROM Employees WHERE Id = @Id";
            foreach (DataGridViewRow row in this.dgvEmployees.SelectedRows)
            {
                using (SqliteConnection connection = new SqliteConnection(stringConnection))
                {
                    SqliteCommand command = new SqliteCommand(query, connection);

                    Employee employee = (Employee)row.Tag;
                    command.Parameters.AddWithValue("@Id", employee.Id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        void SortAscendingByName()
        {
            AscCompareEmployeesName ascCompareEmployeesName = new AscCompareEmployeesName();
            employees.Sort(ascCompareEmployeesName);
            DisplayEmployees();

        }

        void SortDescendingByBirthDate()
        {
            DescCompareEmployeesBirthDate descCompareEmployeesBirthDate = new DescCompareEmployeesBirthDate();
            employees.Sort(descCompareEmployeesBirthDate);
            DisplayEmployees();
        }

        void ExportXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            // make dialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export to XML";
            saveFileDialog.Filter = "Xml file | *.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = File.Create(saveFileDialog.FileName))
                {
                    serializer.Serialize(stream, employees);
                }
            }                
        }

        void ImportXML()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import from Xml";
            openFileDialog.Filter = "Xml file | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = File.OpenRead(openFileDialog.FileName))
                {
                    employees = (List<Employee>)serializer.Deserialize(stream);
                }
            }
        }
        #endregion




        #region Events
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            NewEmployeeForm nef = new NewEmployeeForm();
            if (nef.ShowDialog() == DialogResult.OK)
            {
                // need display here
                DisplayEmployees();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            DeleteFromSQL();
            DeleteEmployees();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImportFromSQL();
            DisplayEmployees();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditEmployee();
        }

        private void btnCheckEmployeesDepartment_Click(object sender, EventArgs e)
        {
            CheckEmployeesDepartments();
        }
        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExportToSQL();
        }

        private void btnEraseDb_Click(object sender, EventArgs e)
        {
            employees.Clear();
            DeleteEverythingFromSQL();
            DisplayEmployees();
        }

        private void dgvEmployees_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnSortAscName_Click(object sender, EventArgs e)
        {
            SortAscendingByName();
        }

        private void btnSortDescBirthDate_Click(object sender, EventArgs e)
        {
            SortDescendingByBirthDate();
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            ExportXML();
        }

        private void btnImportXML_Click(object sender, EventArgs e)
        {
            ImportXML();
            DisplayEmployees();
        }

        #endregion


        // how to print
        // 1. MenuStrip - 3 buttons - Print, PrintPreview, PageSetup
        // 2. from toolbox -> PrintDocument printDocument, PageSetupDialog pageSetupDialog(change Document property -> printDocument)
        // 3. Handle click event on PageSetup button
        // 4. Handle print page event of PrintDocument (from2)
        //      // a lot of code here
        // 5. Handle BeginPrint event of PrintDocument (from2)
        // 6. from toolbox -> PrintPreviewDialog printPreviewDialog(change Document property -> printDocument)
        // 7. Handle click event on PrintPreview button
        // 8. from tooblox -> PrintDialog printDialog (change Document property -> printDocument)
        // 9. Handle click event on Print button

    }
}
