using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Triangle : GeometricShape
    {
        public Triangle(double b, double h) : base(b, h) { }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get
            {
                double hypotenuse = Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
                return Dimension1 + Dimension2 + hypotenuse;
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Triangle => Base = {Dimension1}, Height = {Dimension2}");
            base.Display();
        }
    }
}
