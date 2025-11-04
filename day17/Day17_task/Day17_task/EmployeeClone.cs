using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17_task
{
    internal class EmployeeClone : ICloneable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public object Clone() => new EmployeeClone { Name = this.Name, Salary = this.Salary };

        public override string ToString() => $" Name is : {Name} - Salary is : {Salary}";
    }
}
