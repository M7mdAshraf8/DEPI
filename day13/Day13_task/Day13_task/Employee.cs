using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_task
{
    internal struct Employee
    {
        private int empId;
        private string name;
        private decimal salary;

        public Employee(int id, string name, decimal salary)
        {
            this.empId = id;
            this.name = name;
            this.salary = salary;
        }
        public int EmpId
        {
            get { return empId; }
        }
        public string GetName()
        {
            return name;
        }

        public void SetName(string Value)
        {
            name = Value.Length <= 10 ? Value : Value.Substring(0, 10);
        }
        public decimal Salary
        {
            get { return salary; }
            set { salary = value > 0 ? value : 0; } 
        }
        public override string ToString()
        {
            return $"Employee => ID: {empId}, Name: {name}, Salary: {salary:C}";
        }
    }
}
