using Day15_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Circle : Shape,IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Circle with Radius = {Radius}");
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
