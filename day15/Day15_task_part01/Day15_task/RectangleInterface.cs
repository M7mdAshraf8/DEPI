using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class RectangleInterface : Interfaces.IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double Area => throw new NotImplementedException();

        public RectangleInterface(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
