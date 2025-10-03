using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_task.Classess
{
    internal class Helper<T> where T : IComparable<T>
    {
        public static T Max(T a, T b)
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
        public static void ReplaceArray(T[] arr, T oldValue, T newValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(oldValue))
                {
                    arr[i] = newValue;
                }
            }
        }
        public static void PrintArray(T[] arr)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        public static T[] ReverseArray(T[] arr)
        {
            T[] result = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                result[i] = arr[arr.Length - 1 - i];
            return result;
        }
        public static void Swap(T[] arr, int i, int j)
        {
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }
        public static T MaxInArray(T[] arr)
        {
            T max = arr[0];
            foreach (var item in arr)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }
    }
}
