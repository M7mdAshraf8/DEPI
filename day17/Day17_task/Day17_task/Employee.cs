using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_task
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString() => $" Name is : {Name} - Salary is : {Salary}";
    }
}
