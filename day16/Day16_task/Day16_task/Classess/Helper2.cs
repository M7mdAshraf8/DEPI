using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Helper2<T>
    {
        public static int SearchArray(T[] arr, T value)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                if (value.Equals(arr[i]))
                    return i;
            }
            return -1;
        }
    }
}
