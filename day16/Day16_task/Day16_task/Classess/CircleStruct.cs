using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class CircleStruct
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public override string ToString() => $"CircleStruct: Radius={Radius}, Color={Color}";

        public static bool operator ==(CircleStruct left, CircleStruct right)
        {
            return left.Radius == right.Radius && left.Color == right.Color;
        }

        public static bool operator !=(CircleStruct left, CircleStruct right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is CircleStruct other)
                return this.Radius == other.Radius && this.Color == other.Color;
            return false;
        }
        public override int GetHashCode() => HashCode.Combine(Radius, Color);
    }
}
