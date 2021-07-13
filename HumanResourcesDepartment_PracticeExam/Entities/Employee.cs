using System;
using System.Collections.Generic;

namespace HumanResourcesDepartment_PracticeExam.Entities
{
    public class Employee : IComparable<Employee>
    {
        #region Attributes + Properties
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Wage { get; set; }
        public int IdDepartment { get; set; }
        #endregion

        #region Constructors
        public Employee()
        {

        }

        public Employee(long id, string name, DateTime birthDate, double wage, int idDepartment)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Wage = wage;
            IdDepartment = IdDepartment;
        }
        #endregion

        public static explicit operator bool(Employee employee)
        {
            //if (employee.IdDepartment != 0)
            //{
            //    return true;
            //}
            //return false;
            return employee.IdDepartment != 0 ? true : false;
        }

        public int CompareTo(Employee other)
        {
            return this.Name.CompareTo(other.Name);
        }

    }

        public class AscCompareEmployeesName : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public class DescCompareEmployeesBirthDate : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return - x.BirthDate.CompareTo(y.BirthDate);
            }
        }
    
}
