using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_task
{
    internal struct Point
    {
        public int X;
        public int Y;

        public Point(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }

        public Point(int x)
        {
            X = x;
            Y = 0;
        }
        public override string ToString()
        {
            //return $"first is {X} Second is {Y}"; // P1 & P4
            return $"Point Coordinates => (X: {X}, Y: {Y})"; //P5
        }

    }
}
