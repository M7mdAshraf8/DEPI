using Day16_task.Classess;
using System;

namespace Day16_task
{
    internal class Program
    {
        enum Weekdays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }
        enum Grades : short
        {
            A,
            B = 2,
            C,
            D,
            F = 1
        }
        enum GenderInt 
        {
            Male,
            Female
        }

        enum GenderByte : byte 
        {
            Male,
            Female
        }
        enum GradesP9
        {
            A,
            B,
            C,
            D,
            F
        }
        public static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = r1;
            r1 = r2;
            r2 = temp;
        }
        static void Main(string[] args)
        {
            #region Part01
            #region P1
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day} = {(int)day}");
            //} 
            #endregion

            #region p2
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade} = {(short)grade}");
            //} 
            #endregion

            #region P3
            //Person p1 = new Person { Id = 1, Name = "Ali", Department = "IT" };
            //Person p2 = new Person { Id = 2, Name = "Mona", Department = "HR" };

            //Console.WriteLine(p1);
            //Console.WriteLine(p2); 
            #endregion

            #region P4
            //Child ch = new Child();
            //ch.Salary = 3000;
            //ch.DisplaySalary();   
            #endregion

            #region P5
            //double perimeter = Utility.CalcRectanglePerimeter(5, 3);
            //Console.WriteLine($"Perimeter = {perimeter}"); 
            #endregion

            #region P6
            //ComplexNumber c1 = new ComplexNumber { Real = 2, Imag = 3 };
            //ComplexNumber c2 = new ComplexNumber { Real = 4, Imag = 5 };

            //ComplexNumber result = c1 * c2;

            //Console.WriteLine($"{c1} * {c2} = {result}"); 
            #endregion

            #region P7
            //Console.WriteLine($"Size of GenderInt: {sizeof(GenderInt)} bytes");
            //Console.WriteLine($"Size of GenderByte: {sizeof(GenderByte)} bytes"); 
            #endregion

            #region P8
            //double c = 25;
            //double f = Utility.CelsiusToFahrenheit(c);
            //Console.WriteLine($"{c} °C = {f} °F");

            //double f2 = 77;
            //double c2 = Utility.FahrenheitToCelsius(f2);
            //Console.WriteLine($"{f2} °F = {c2} °C"); 
            #endregion

            #region P9
            //Console.Write("Enter grade letter (A, B, C, D, F): ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out GradesP9 result))
            //{
            //    Console.WriteLine($"You entered a valid grade: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade entered!");
            //} 
            #endregion

            #region P10
            //Employee[] employees =
            //{
            //    new Employee { Id = 1, Name = "Ali", Salary = 5000 },
            //    new Employee { Id = 2, Name = "Mona", Salary = 6000 },
            //    new Employee { Id = 3, Name = "Omar", Salary = 7000 }
            //};

            //Employee target = new Employee { Id = 2, Name = "Mona", Salary = 6000 };

            //int index = Helper2<Employee>.SearchArray(employees, target);

            //Console.WriteLine(index >= 0 ? $"Employee found at index {index}" : "Employee not found");
            #endregion

            #region P11
            //int maxInt = Helper<int>.Max(10, 20);
            //double maxDouble = Helper<double>.Max(5.5, 2.3);
            //string maxString = Helper<string>.Max("Ali", "Omar");

            //Console.WriteLine($"Max Int: {maxInt}");
            //Console.WriteLine($"Max Double: {maxDouble}");
            //Console.WriteLine($"Max String: {maxString}"); 
            #endregion

            #region P12
            //int[] numbers = { 1, 2, 3, 2, 4, 2, 5 };
            //Console.WriteLine("Before Replace:");
            //Helper<int>.PrintArray(numbers);

            //Helper<int>.ReplaceArray(numbers, 2, 99);
            //Console.WriteLine("After Replace:");
            //Helper<int>.PrintArray(numbers);

            //string[] names = { "Ali", "Mona", "Ali", "Omar" };
            //Console.WriteLine("\nBefore Replace:");
            //Helper<string>.PrintArray(names);

            //Helper<string>.ReplaceArray(names, "Ali", "Ahmed");
            //Console.WriteLine("After Replace:");
            //Helper<string>.PrintArray(names); 
            #endregion

            #region P13
            //Rectangle rect1 = new Rectangle { Length = 5, Width = 10 };
            //Rectangle rect2 = new Rectangle { Length = 7, Width = 14 };

            //Console.WriteLine("Before Swap:");
            //Console.WriteLine(rect1);
            //Console.WriteLine(rect2);

            //Swap(ref rect1, ref rect2);

            //Console.WriteLine("\nAfter Swap:");
            //Console.WriteLine(rect1);
            //Console.WriteLine(rect2); 
            #endregion

            #region P14
            //    Department it = new Department { DeptId = 1, DeptName = "IT" };
            //    Department hr = new Department { DeptId = 2, DeptName = "HR" };

            //    Employee[] employees =
            //    {
            //    new Employee { Id = 1, Name = "Ali", Department = it },
            //    new Employee { Id = 2, Name = "Mona", Department = hr },
            //    new Employee { Id = 3, Name = "Omar", Department = it }
            //};

            //    Employee target = new Employee { Id = 3, Name = "Omar", Department = it };

            //    int index = Helper2<Employee>.SearchArray(employees, target);

            //    Console.WriteLine(index >= 0
            //        ? $"Employee found at index {index}: {employees[index]}"
            //        : "Employee not found");
            //    //uncomment in public override bool Equals(object obj) in Employee class 
            #endregion

            #region P15
            //CircleStruct s1 = new CircleStruct { Radius = 5, Color = "Red" };
            //CircleStruct s2 = new CircleStruct { Radius = 5, Color = "Red" };
            //Console.WriteLine("=== Struct Comparison ===");
            //Console.WriteLine($"s1 == s2 : {s1 == s2}");     
            //Console.WriteLine($"s1.Equals(s2) : {s1.Equals(s2)}"); 


            //CircleClass c1 = new CircleClass { Radius = 5, Color = "Red" };
            //CircleClass c2 = new CircleClass { Radius = 5, Color = "Red" };
            //Console.WriteLine("\n=== Class Comparison ===");
            //Console.WriteLine($"c1 == c2 : {c1 == c2}");     
            //Console.WriteLine($"c1.Equals(c2) : {c1.Equals(c2)}");  
            #endregion 
            #endregion

            #region Part02
            //int[] nums = { 1, 2, 3, 4 };
            //string[] names = { "Ali", "Mona", "Omar" };

            ////P1
            //Console.WriteLine(string.Join(", ", Helper<int>.ReverseArray(nums)));
            //Console.WriteLine(string.Join(", ", Helper<string>.ReverseArray(names)));
            //Console.WriteLine();

            ////P2
            //MyStack<int> stack = new MyStack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //Console.WriteLine(stack.Peek()); 
            //Console.WriteLine(stack.Pop());  
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine();

            ////P3
            //Helper<int>.Swap(nums, 0, 2);
            //Console.WriteLine(string.Join(", ", nums));
            //Helper<string>.Swap(names, 0, 1);
            //Console.WriteLine(string.Join(", ", names));
            //Console.WriteLine();

            ////P4
            //Console.WriteLine(Helper<int>.MaxInArray(nums));
            //Console.WriteLine(Helper<string>.MaxInArray(names));   
            #endregion
        }
    }
}
