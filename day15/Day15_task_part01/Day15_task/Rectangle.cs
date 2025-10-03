using Day15_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Rectangle : Shape,IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get { return Width * Height; }
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle with Width={Width}, Height={Height}, Area={Area}");
        }
        public override double GetArea()
        {
            return Width * Height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
