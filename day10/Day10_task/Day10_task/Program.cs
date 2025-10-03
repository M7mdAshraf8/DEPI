using System;
using System.Text;
namespace Day10_task
{
    class Program
    {
        public static void Main()
        {
            #region Problem1
            //Console.Write("Enter a Number: ");
            //string input = Console.ReadLine();

            ////using int.Parse
            //try
            //{
            //    int ParsedValue = int.Parse(input);
            //    Console.WriteLine($"int.Parse result: {ParsedValue}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"int.Parse failed: {ex.Message}");
            //}

            ////using Convert.ToInt32
            //try
            //{
            //    int ConvertedValue = Convert.ToInt32(input);
            //    Console.WriteLine($"Convert.ToInt32 result: {ConvertedValue}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Convert.ToInt32 failed: {ex.Message}");
            //} 
            #endregion

            #region Problem2
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //bool isValid = int.TryParse(input, out int num);

            //if (isValid)
            //{
            //    Console.WriteLine($"U entered: {num}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.Please enter a valid integer.");
            //} 
            #endregion

            #region Problem3
            //object obj;

            ////assign int
            //obj = 22;
            //Console.WriteLine($"Value: {obj}, HashCode: {obj.GetHashCode()}");

            ////assign string
            //obj = "Mody";
            //Console.WriteLine($"Value: {obj}, HashCode: {obj.GetHashCode()}");

            ////assign double
            //obj = 35.350;
            //Console.WriteLine($"Value: {obj}, HashCode: {obj.GetHashCode()}"); 
            #endregion

            #region Problem4
            //object obj1 = new StringBuilder("Hello");
            //
            //Console.WriteLine($"obj1 = {obj1}");
            //
            //object obj2 = obj1;
            //
            //((StringBuilder)obj1).Append(" World");
            //
            //Console.WriteLine($"obj2 = {obj2}");

            #endregion

            #region Problem5
            //string msg = "Hello";
            //Console.WriteLine($"Before: {msg}, HashCode: {msg.GetHashCode()}");

            //msg += " Hi Willy";
            //Console.WriteLine($"After: {msg}, HashCode: {msg.GetHashCode()}"); 
            #endregion

            #region Problem6
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine($"Before: {sb}, HashCode: {sb.GetHashCode()}");

            //sb.Append("! Welcome.");
            //Console.WriteLine($"After: {sb}, HashCode: {sb.GetHashCode()}"); 
            #endregion

            #region Problem7
            //Console.Write("Enter the first number: ");
            //bool isValid1 = int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter the second number: ");
            //bool isValid2 = int.TryParse(Console.ReadLine(), out int num2);

            //if (isValid1 && isValid2)
            //{
            //    int sum = num1 + num2;

            //    Console.WriteLine("Sum is " + num1 + " + " + num2 + " = " + sum);
            //    Console.WriteLine(string.Format("Sum is {0} + {1} = {2}", num1, num2, sum));
            //    Console.WriteLine($"Sum is {num1} + {num2} = {sum}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter valid integers.");
            //} 
            #endregion

            #region Problem8
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello World");
            //Console.WriteLine("After Append: " + sb);

            //sb.Replace("World", "Mody");
            //Console.WriteLine("After Replace: " + sb);

            //sb.Insert(6, "dear ");
            //Console.WriteLine("After Insert: " + sb);

            //sb.Remove(6, 5);
            //Console.WriteLine("After Remove: " + sb); 
            #endregion
        }
    }
}
