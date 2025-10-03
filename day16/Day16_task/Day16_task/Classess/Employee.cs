using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Salary : {Salary} , Dept : {Department}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee other)
            {
                return this.Id == other.Id &&
                       this.Name == other.Name &&
                       this.Salary == other.Salary;/*&&
                       this.Department.Equals(other.Department);*/
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary, Department);
        }

    }
}
