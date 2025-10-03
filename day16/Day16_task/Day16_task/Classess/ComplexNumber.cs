using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static ComplexNumber operator *(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = (left.Real * right.Real) - (left.Imag * right.Imag),
                Imag = (left.Real * right.Imag) + (left.Imag * right.Real)
            };
        }
    }
}
