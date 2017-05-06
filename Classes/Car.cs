using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest.Classes
{
    public class Car
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }

        public Car (int id, int employeeId, string model, string number)
        {
            Id = id;
            EmployeeId = employeeId;
            Model = model;
            Number = number;
        }
    }
}
