using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Rectangle : GeometricShape
    {
        public Rectangle(double l, double w) : base(l, w) { }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

        public override double Perimeter
        {
            get { return 2 * (Dimension1 + Dimension2); }
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle => Length = {Dimension1}, Width = {Dimension2}");
            base.Display();
        }
    }
}
