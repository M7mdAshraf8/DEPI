using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value + 2000; }
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary = {Salary}");
        }
    }
}
