using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public abstract double CalculateArea();

        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }

}
