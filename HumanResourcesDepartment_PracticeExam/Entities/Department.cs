using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesDepartment_PracticeExam.Entities
{
    public class Department
    {
        #region Attributes + Properties
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constructors
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion


    }
}
