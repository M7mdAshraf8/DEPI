using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override string ToString()
        {
            return $"Rectangle (Length={Length}, Width={Width})";
        }
    }
}
