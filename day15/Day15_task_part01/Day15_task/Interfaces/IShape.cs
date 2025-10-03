using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task.Interfaces
{
    internal interface IShape
    {
        double Area { get; }
        void Draw();
        double GetArea();
        void PrintDetails()
        {
            Console.WriteLine($"Shape details: Area = {Area}");
        }
    }
}
