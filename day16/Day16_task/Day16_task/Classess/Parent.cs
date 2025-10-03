using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value + 1000; }
        }
    }
}
