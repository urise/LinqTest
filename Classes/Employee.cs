using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest.Classes
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }

        public Employee(int id, string fullName, int age, int departmentId)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            DepartmentId = departmentId;
        }
    }
}
