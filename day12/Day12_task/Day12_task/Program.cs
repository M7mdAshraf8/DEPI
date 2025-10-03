using System;
using System.Collections.Generic;
using System.Linq;

namespace Day12_task
{

    internal class Program
    {
        #region Part 1
        #region Problem2
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;

        //    do
        //    {
        //        Console.Write("Enter first positive number: ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

        //    do
        //    {
        //        Console.Write("Enter second positive number greater than 1: ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //    Z = X / Y;
        //    Console.WriteLine($"Result = {Z}");
        //} 
        #endregion

        #region Problem9
        //static void SumAndMultiply(int a, int b, out int sum, out int product)
        //{
        //    sum = a + b;
        //    product = a * b;
        //} 
        #endregion

        #region Problem10
        //static void PrintMessage(string message, int count = 5)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(message);
        //    }
        //}
        #endregion

        #region Problem13
        //static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int num in numbers)
        //        sum += num;
        //    return sum;
        //} 
        #endregion 
        #endregion
        static void Main()
        {
            #region Part 1
            #region Problem1
            //try
            //{
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine($"Result = {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Error: Cannot divide by zero!");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //} 
            #endregion

            #region Problem2
            //try
            //{
            //    TestDefensiveCode();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}
            #endregion

            #region Problem3
            //int? nullableInt = null;

            //Console.WriteLine($"HasValue: {nullableInt.HasValue}");

            //if (nullableInt.HasValue)
            //{
            //    Console.WriteLine($"Value: {nullableInt.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("Value: null");
            //}

            //int result = nullableInt ?? 42;
            //Console.WriteLine($"Result : {result}");

            //nullableInt = 100;
            //Console.WriteLine($"HasValue: {nullableInt.HasValue}");
            //Console.WriteLine($"Value: {nullableInt.Value}");

            //result = nullableInt ?? 42;
            //Console.WriteLine($"Result : {result}"); 
            #endregion

            #region Problem4
            //try
            //{
            //    int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
            //    Console.WriteLine(numbers[7]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //} 
            #endregion

            #region Problem5
            //int[,] matrix = new int[3, 3];

            //Console.WriteLine("Enter values for a 3x3 matrix:");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        bool validInput;
            //        do
            //        {
            //            Console.Write($"Element [{i + 1},{j + 1}]: ");
            //            validInput = int.TryParse(Console.ReadLine(), out matrix[i, j]);
            //            if (!validInput)
            //            {
            //                Console.WriteLine("Error: Please enter a valid integer.");
            //            }
            //        } while (!validInput);
            //    }
            //}

            //Console.WriteLine("\nSum of each row:");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        rowSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Row {i + 1}: {rowSum}");
            //}

            //Console.WriteLine("\nSum of each column:");
            //for (int j = 0; j < matrix.GetLength(1); j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        colSum += matrix[i, j];
            //    }
            //    Console.WriteLine($"Column {j + 1}: {colSum}");
            //}
            #endregion

            #region Problem6
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[2]; 
            //jaggedArray[1] = new int[4]; 
            //jaggedArray[2] = new int[3]; 

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    Console.WriteLine($"\nEnter values for row {i+1}:");
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        bool validInput;
            //        do
            //        {
            //            Console.Write($"Element [{i + 1},{j + 1}]: ");
            //            validInput = int.TryParse(Console.ReadLine(), out jaggedArray[i][j]);
            //            if (!validInput)
            //            {
            //                Console.WriteLine("Error: Please enter a valid integer.");
            //            }
            //        } while (!validInput);
            //    }
            //}

            //Console.WriteLine("\nJagged array contents:");
            //for (int i = 0; i < jaggedArray.Length; i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem7
            //#nullable enable
            //            string? name = null; 

            //            Console.Write("Enter your name: ");
            //            string input = Console.ReadLine()!;

            //            if (!string.IsNullOrEmpty(input))
            //            {
            //                name = input;
            //                Console.WriteLine($"Hello, {name}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("No name provided.");
            //            }       
            //#nullable disable 
            #endregion

            #region Problem8
            //try
            //{
            //    int number = 42;
            //    object boxed = number;
            //    Console.WriteLine($"Boxed value: {boxed}");

            //    int unboxed = (int)boxed;
            //    Console.WriteLine($"Unboxed value: {unboxed}");

            //    object wrongType = "Not an int";
            //    int invalidCast = (int)wrongType;
            //    Console.WriteLine(invalidCast);
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine("Invalid cast detected: " + ex.Message);
            //}         
            #endregion

            #region Problem9
            //int num1 = 5, num2 = 3;

            //SumAndMultiply(num1, num2, out int resultSum, out int resultProduct);

            //Console.WriteLine($"Sum: {resultSum}, Product: {resultProduct}"); 
            #endregion

            #region Problem10
            //PrintMessage("Hello");
            //Console.WriteLine();

            //PrintMessage("Hi there", 3);
            //Console.WriteLine();

            //PrintMessage(count: 2, message: "Mohamed"); 
            #endregion

            #region Problem11
            //#nullable enable
            //            int[]? numbers = null;

            //            int? length = numbers?.Length;

            //            Console.WriteLine($"Array length: {length ?? 0}"); 

            //            numbers = new int[] { 1, 2, 3, 4 };

            //            length = numbers?.Length;
            //            Console.WriteLine($"Array length after initialization: {length}");
            //#nullable disable 
            #endregion

            #region Problem12
            //#nullable enable
            //            Console.Write("Enter a day of the week: ");
            //            string? day = Console.ReadLine()?.Trim().ToLower();

            //            if (string.IsNullOrEmpty(day))
            //            {
            //                Console.WriteLine("Error: Input cannot be empty.");
            //                return;
            //            }

            //            int dayNumber = day switch
            //            {
            //                "monday" => 1,
            //                "tuesday" => 2,
            //                "wednesday" => 3,
            //                "thursday" => 4,
            //                "friday" => 5,
            //                "saturday" => 6,
            //                "sunday" => 7,
            //                _ => -1
            //            };

            //            if (dayNumber != -1)
            //            {
            //                Console.WriteLine($"The day '{day}' corresponds to number {dayNumber}.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"Error: '{day}' is not a valid day of the week.");
            //            }
            //#nullable disable 
            #endregion

            #region Problem13
            //Console.WriteLine(SumArray(1, 2, 3, 4));

            //int[] nums = { 5, 10, 15 };
            //Console.WriteLine(SumArray(nums)); 
            #endregion
            #endregion

            #region Part 2
            #region P1
            //Console.Write("Enter a positive integer: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i < number)
            //        Console.Write(i + ", ");
            //    else
            //        Console.Write(i);
            //} 
            #endregion

            #region P2
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i);
            //    if (i < 12)
            //        Console.Write(", ");
            //} 
            #endregion

            #region P3
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= num; i += 2)
            //{
            //    Console.Write(i);
            //    if (i < num && i + 2 <= num)
            //        Console.Write(", ");
            //} 
            #endregion

            #region P4
            //Console.Write("Enter the base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine($"{baseNum}^{exponent} = {result}"); 
            #endregion

            #region P5
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}

            //Console.WriteLine($"Reversed string: {reversed}"); 
            #endregion

            #region P6
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;      
            //    reversed = reversed * 10 + digit; 
            //    number /= 10;                
            //}

            //Console.WriteLine($"Reversed number: {reversed}"); 
            #endregion

            #region P7
            //Console.Write("Enter array elements separated by space: ");
            //string[] input = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(input, int.Parse);

            //Dictionary<int, int> firstIndexMap = new Dictionary<int, int>();

            //int maxDistance = -1;
            //int element = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (!firstIndexMap.ContainsKey(arr[i]))
            //    {
            //        firstIndexMap[arr[i]] = i;
            //    }
            //    else
            //    {
            //        int distance = i - firstIndexMap[arr[i]] - 1;
            //        if (distance > maxDistance)
            //        {
            //            maxDistance = distance;
            //            element = arr[i];
            //        }
            //    }
            //}

            //if (maxDistance >= 0)
            //    Console.WriteLine($"Longest distance is {maxDistance} between two {element}'s.");
            //else
            //    Console.WriteLine("No repeating elements found."); 
            #endregion

            #region P8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string reversed = string.Join(" ", sentence.Split(' ').Reverse());

            //Console.WriteLine(reversed); 
            #endregion 
            #endregion

        }
    }
}
