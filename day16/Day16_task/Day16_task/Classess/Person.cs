using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; } 

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Department: {Department}";
        }
    }
}
