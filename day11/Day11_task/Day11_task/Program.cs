using System;

namespace Day11_task
{
    class Program
    {
        static void Main()
        {
            #region Problem1
            //int[] arr1 = new int[3];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //int[] arr2 = new int[3] { 40, 50, 60 };

            //int[] arr3 = { 70, 80, 90 };
            //Console.WriteLine("Array1:");
            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Array2:");
            //foreach (int item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Array3:");
            //foreach (int item in arr3)
            //{
            //    Console.WriteLine(item);
            //}

            //try
            //{
            //    Console.WriteLine(arr1[3]);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //} 
            #endregion

            #region Problem2
            //int[] arr1 = { 10, 20, 30 };
            //int[] arr2 = { 40, 50, 60 };
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //Console.WriteLine("Shallow Copy:");
            //arr2 = arr1;
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr2[0] = 99;
            //Console.WriteLine($"arr1[0] = {arr1[0]}"); 
            //Console.WriteLine($"arr2[0] = {arr2[0]}");

            //arr2 = (int[])arr1.Clone();
            //Console.WriteLine("Deep Copy:");
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr2[1] = 77;
            //Console.WriteLine($"arr1[1] = {arr1[1]}"); //Still original value
            //Console.WriteLine($"arr3[1] = {arr2[1]}"); //Modified value 
            #endregion

            #region Problem3
            //int[,] grades = new int[3, 3];
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");
            //    for (int j = 0; j < grades.GetLength(1);)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        bool flag = int.TryParse(Console.ReadLine(), out grades[i, j]);
            //        j = (flag && grades[i, j] >= 0) ? ++j : j;
            //    }
            //}
            //Console.WriteLine("\n--- Grades ---");
            //for (int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Student {i + 1}:");
            //    for (int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Subject {j + 1}: {grades[i, j]}");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem4
            //int[] num = { 9, 3, 10, 2, 8, 10, 6, 5, 1 };
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = new int[5];

            //Console.WriteLine("1. Sort Method:");
            //Console.WriteLine($"Before Sort: num = {string.Join(", ", num)}");
            //Array.Sort(num);
            //Console.WriteLine($"After Sort: num = {string.Join(", ", num)}\n");

            //Console.WriteLine("2. Reverse Method:");
            //Console.WriteLine($"Before Reverse: arr01 = {string.Join(", ", arr1)}");
            //Array.Reverse(arr1);
            //Console.WriteLine($"After Reverse: arr01 = {string.Join(", ", arr1)}\n");

            //Console.WriteLine("3. IndexOf Method:");
            //Console.WriteLine($"Array num = {string.Join(", ", num)}");
            //int index = Array.IndexOf(num, 10);
            //Console.WriteLine($"First index of 10: {index}\n");

            //Console.WriteLine("4. Copy Method:");
            //Console.WriteLine($"Before Copy: arr02 = {string.Join(", ", arr2)}");
            //Array.Copy(arr1, arr2, 2);
            //Console.WriteLine($"After Copy (first 2 elements from arr01): arr02 = {string.Join(", ", arr2)}\n");

            //Console.WriteLine("5. Clear Method:");
            //Console.WriteLine($"Before Clear: num = {string.Join(", ", num)}");
            //Array.Clear(num, 2, 4);
            //Console.WriteLine($"After Clear (elements 2 to 5): num = {string.Join(", ", num)}"); 
            #endregion

            #region Problem5
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Using for:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("Using foreach:");
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("Using while(reverse order):");
            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.WriteLine(numbers[index]);
            //    index--;
            //} 
            #endregion

            #region Problem6
            //int Num;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    flag = int.TryParse(Console.ReadLine(), out Num);
            //    if (Num % 2 == 0 || !flag || Num <= 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive odd number.");
            //    }
            //}
            //while (Num % 2 == 0 || !flag || Num <= 0);
            //Console.WriteLine($"You entered: {Num}"); 
            #endregion

            #region Problem7
            //int[,] matrix = {{ 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 }};

            //Console.WriteLine("Matrix elements:");
            //for (int i = 0; i < matrix.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) 
            //    {
            //        Console.Write(matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Problem8
            //Console.Write("Enter month number(1-12): ");
            //bool flag = int.TryParse(Console.ReadLine(), out int month);

            //if (!flag || month < 1 || month > 12)
            //{
            //    Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
            //    return;
            //}

            //Console.WriteLine("\n--- Using if-else ---");
            //string monthName;
            //if (month == 1) monthName = "January";
            //else if (month == 2) monthName = "February";
            //else if (month == 3) monthName = "March";
            //else if (month == 4) monthName = "April";
            //else if (month == 5) monthName = "May";
            //else if (month == 6) monthName = "June";
            //else if (month == 7) monthName = "July";
            //else if (month == 8) monthName = "August";
            //else if (month == 9) monthName = "September";
            //else if (month == 10) monthName = "October";
            //else if (month == 11) monthName = "November";
            //else monthName = "December";
            //Console.WriteLine($"Month {month} is {monthName}");

            //Console.WriteLine("\n--- Using switch ---");
            //switch (month)
            //{
            //    case 1: Console.WriteLine($"Month {month} is January"); break;
            //    case 2: Console.WriteLine($"Month {month} is February"); break;
            //    case 3: Console.WriteLine($"Month {month} is March"); break;
            //    case 4: Console.WriteLine($"Month {month} is April"); break;
            //    case 5: Console.WriteLine($"Month {month} is May"); break;
            //    case 6: Console.WriteLine($"Month {month} is June"); break;
            //    case 7: Console.WriteLine($"Month {month} is July"); break;
            //    case 8: Console.WriteLine($"Month {month} is August"); break;
            //    case 9: Console.WriteLine($"Month {month} is September"); break;
            //    case 10: Console.WriteLine($"Month {month} is October"); break;
            //    case 11: Console.WriteLine($"Month {month} is November"); break;
            //    case 12: Console.WriteLine($"Month {month} is December"); break;
            //    default: Console.WriteLine("Invalid month number"); break;
            //} 
            #endregion

            #region Problem9
            //int[] num = { 8, 3, 1, 9, 5, 3, 7 };

            //Array.Sort(num);
            //Console.WriteLine("Sorted array: " + string.Join(", ", num));

            //Console.Write("Enter a value to search: ");
            //int value = int.Parse(Console.ReadLine());

            //int firstIndex = Array.IndexOf(num, value);
            //int lastIndex = Array.LastIndexOf(num, value);

            //if (firstIndex != -1)
            //{
            //    Console.WriteLine($"First index of {value}: Index {firstIndex}");
            //    Console.WriteLine($"Last index of {value}: Index {lastIndex}");
            //}
            //else
            //{
            //    Console.WriteLine($"{value} not found in the array.");
            //}
            #endregion

            #region Problem10
            //int[] numbers = { 5, 10, 15, 20, 25 };

            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine($"Sum using for: {sumFor}");

            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine($"Sum using foreach: {sumForeach}"); 
            #endregion

        }
    }
}
