using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public override string ToString() => $"CircleClass: Radius={Radius}, Color={Color}";

        public override bool Equals(object obj)
        {
            if (obj is CircleClass other)
                return this.Radius == other.Radius && this.Color == other.Color;
            return false;
        }
        public override int GetHashCode() => HashCode.Combine(Radius, Color);
    }
}
