using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using static System.Formats.Asn1.AsnWriter;
namespace Day09_task
{
    class Program
    {
        static void Main()
        {
            #region Problem1
            //// This program calculates the sum of two integers and prints the result

            //int x = 10;  // Declare first number
            //int y = 20;  // Declare second number

            ///*
            // The following line adds x and y
            // and stores the result in the variable sum
            //*/
            //int sum = x + y;

            //// Print the result to the console
            //Console.WriteLine(sum);

            ////To comment a selected block:
            ////Ctrl + K +C

            ////To uncomment a selected block:
            ////Ctrl + K +U 
            #endregion

            #region Problem2
            //int x = 10;                
            //int y = 20;                // add y
            //Console.WriteLine(x + y); // fix casing of 'Console'

            ////Runtime Error :An error that occurs while the program is running. Usually causes the program to crash.
            ////              :Program compiles but crashes at runtime.
            //string input = "abc";
            //int number = int.Parse(input); //FormatException
            //Console.WriteLine(number);

            ////Logical Error :An error in the logic of the program. The program runs but produces incorrect results.
            ////              :Program runs without crashing, but gives wrong output.
            //int length = 5;
            //int width = 3;
            //int area = 2 * (length + width); //Wrong logic for area
            //Console.WriteLine("Area is: " + area); 
            #endregion

            #region Problem3
            //// Declare variables with appropriate data types and naming conventions

            //string FullName = "Mohamed Ashraf";
            //int Age = 25;
            //decimal MonthlySalary = 5000.75m;
            //bool IsStudent = true;

            ///*Importance of Naming Conventions(e.g., PascalCase, camelCase)
            //Readability: Makes code easy to read and understand.

            //Consistency: Helps teams write code in the same style.

            //Maintainability: Easier to update and debug code later.

            //Professionalism: Shows clean, organized, and disciplined coding.

            //Tool Support: Some tools depend on proper naming(e.g., serialization uses PascalCase for properties).*/ 
            #endregion

            #region Problem4
            //Person P1 = new Person();
            //P1.Name = "Ali";
            //P1.Age = 30;

            //Person P2 = P1; //Both point to the same object in memory

            //P2.Name = "Omar";    //Changing P2 also changes P1
            //P1.Age = 25;        //Changing P2 also changes P1

            //Console.WriteLine(P1.Name); //Omar
            //Console.WriteLine(P2.Name); //Omar
            //Console.WriteLine(P1.Age);  //25
            //Console.WriteLine(P2.Age);  //25 

            //Value types store the actual data in the stack.
            //Reference types store a reference in the stack, but the data itself is in the heap.
            //Modifying a reference type through one variable affects all others pointing to it.
            #endregion

            #region Problem5
            //int x = 15;
            //int y = 4;

            //int sum = x + y;
            //int difference = x - y;
            //int product = x * y;
            //int division = x / y;      // Integer division
            //int remainder = x % y;

            //Console.WriteLine("Sum: " + sum);               // 19
            //Console.WriteLine("Difference: " + difference); // 11
            //Console.WriteLine("Product: " + product);       // 60
            //Console.WriteLine("Division: " + division);     // 3
            //Console.WriteLine("Remainder: " + remainder);   // 3

            //int a = 2, b = 7;
            //Console.WriteLine(a % b);                       // 2
            ////2 % 7 means: divide 2 by 7 quotient = 0, remainder = 2
            ////Since 2 is less than 7, it cannot be divided , remainder is the number itself. 
            #endregion

            #region Problem6
            //int num = 14;

            //if (num > 10 && num % 2 == 0)
            //{
            //    Console.WriteLine("The number is greater than 10 and even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number does not meet both conditions.");
            //}

            ////&& -> Combines two conditions. Short-circuits (skips second if first is false).
            ////&  -> Compares individual bits of integers.Can also be used in boolean logic but no short-circuiting. 
            #endregion

            #region Problem7
            //Console.Write("Enter a double value: ");
            //double DoubleValue = Convert.ToDouble(Console.ReadLine());

            ////Explicit casting(double -> int)
            //int ExplicitValue = (int)DoubleValue;

            ////Implicit casting
            //double BackToDouble = ExplicitValue;

            //Console.WriteLine("Original double value: " + DoubleValue);
            //Console.WriteLine("After explicit casting to int: " + ExplicitValue);
            //Console.WriteLine("After implicit casting back to double: " + BackToDouble);

            ///*Why is Explicit Casting Required from double to int?
            //Possible Data Loss
            //double holds decimal/ fractional values(3.14,7.9)
            //int can only hold whole numbers
            //When you cast from double to int, the fractional part is truncated(cut off), which can lead to loss of data*/ 
            #endregion

            #region Problem8
            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);
            //try
            //{

            //    if (age > 0)
            //    {
            //        Console.WriteLine("Your age is valid: " + age);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Age must be greater than 0.");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input! Please enter a numeric value.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("The number you entered is too large or too small.");
            //}

            ////What Exception Might Occur and How to Handle It?
            //// 1 - FormatException    If user enters non-numeric input(e.g., "abc")
            //// 2 - OverflowException  If user enters a number too large or too small for an int(e.g., 9999999999)
            //// How to Handle It:
            ////Use a try-catch block:
            ////try to parse the input
            ////catch specific exceptions and show clear messages to the user 
            #endregion

            #region Problem9
            //int x = 5;

            ////Prefix
            //int prefix = ++x;  //x = 6,prefix = 6

            //x = 5;

            ////Postfix
            //int postfix = x++; //postfix = 5,x = 6

            //Console.WriteLine("After prefix (++x), x = 6 and value = " + prefix);
            //Console.WriteLine("After postfix (x++), x = 6 and value = " + postfix);

            //int z = 5;
            //int y = ++z + z++;  //6+6 = 12
            //Console.WriteLine("Y = " + y);

            ////1 - Initial value: z = 5
            ////2 - ++z > prefix increment:
            ////    z becomes 6, and 6 is used.
            ////3 - z++ > postfix increment:
            ////    6 is used, then z becomes 7 
            #endregion
        }
    }
}
