using System;
using System.Collections.Generic;

namespace Day17_task
{
    #region P13
    public delegate R Transformer<T, R>(T item);
    #endregion
    internal class Program
    {
        #region P09
        public static T GetDefault<T>()
        {
            return default(T);
        }
        #endregion

        #region P11
        public delegate string StringTransformer(string input);
        public static List<string> TransformStrings(List<string> list, StringTransformer transformer)
        {
            List<string> result = new List<string>();
            foreach (var s in list) result.Add(transformer(s));
            return result;
        }
        #endregion

        #region P12
        public delegate int IntOperation(int a, int b);
        public static int Perform(int a, int b, IntOperation op) => op(a, b);
        #endregion

        #region P13
        public static List<R> Transform<T, R>(List<T> list, Transformer<T, R> transformer)
        {
            List<R> result = new List<R>();
            foreach (var item in list) result.Add(transformer(item));
            return result;
        }
        #endregion

        #region P14
        public static List<int> Apply(List<int> list, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (var item in list) result.Add(func(item));
            return result;
        }
        #endregion

        #region P15
        public static void Apply(List<string> list, Action<string> action)
        {
            foreach (var item in list) action(item);
        }
        #endregion

        #region P16
        public static List<int> Filter(List<int> list, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
                if (predicate(item)) result.Add(item);
            return result;
        }
        #endregion

        #region P17,19
        public static List<string> Filter(List<string> list, Func<string, bool> condition)
        {
            List<string> result = new List<string>();
            foreach (var item in list)
                if (condition(item)) result.Add(item);
            return result;
        } 
        #endregion

        static void Main()
        {
            #region P01
            //Employee[] employees = new Employee[]
            //{
            //new Employee { Name = "Ali", Salary = 5000 },
            //new Employee { Name = "Sara", Salary = 7000 },
            //new Employee { Name = "Omar", Salary = 4000 }
            //};

            //SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();
            //sorter.Sort(employees, (e1, e2) => e1.Salary.CompareTo(e2.Salary));

            //Console.WriteLine("Employees sorted by Salary (ascending):");
            //foreach (var emp in employees)
            //    Console.WriteLine(emp);

            #endregion

            #region P02
            //int[] numbers = { 5, 2, 8, 1, 3 };

            //SortingTwo<int> sorter = new SortingTwo<int>();
            //sorter.Sort(numbers, (x, y) => y.CompareTo(x)); // Descending

            //Console.WriteLine(string.Join(", ", numbers));

            #endregion

            #region P03
            //string[] words = { "cat", "elephant", "lion" };

            //SortingTwo<string> sorter = new SortingTwo<string>();
            //sorter.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            //Console.WriteLine(string.Join(", ", words));

            #endregion

            #region P04
            //Manager[] managers =
            //{
            //new Manager { Name = "Ali", Salary = 7000 },
            //new Manager { Name = "Mona", Salary = 6000 },
            //new Manager { Name = "Hany", Salary = 8000 }
            //};

            //Array.Sort(managers);

            //foreach (var m in managers)
            //    Console.WriteLine($"{m.Name} - {m.Salary}");

            #endregion

            #region P05
            //Employee[] employees = {
            //new Employee { Name="Ali", Salary=5000 },
            //new Employee { Name="Ahmed", Salary=6000 },
            //new Employee { Name="Mohamed", Salary=4000 }
            //};

            //Func<Employee, Employee, bool> compareByNameLength = (a, b) => a.Name.Length < b.Name.Length;

            //Array.Sort(employees, (a, b) => compareByNameLength(a, b) ? -1 : 1);

            //Console.WriteLine("Employees sorted by Name Length:");
            //foreach (var e in employees) Console.WriteLine(e);

            #endregion

            #region P06
            //int[] numbers1 = { 9, 2, 7, 1 };

            //Array.Sort(numbers1, delegate (int a, int b) { return a.CompareTo(b); });

            //Console.WriteLine("Sorted with Anonymous Function:");
            //foreach (var n in numbers1) Console.WriteLine(n);

            //int[] numbers2 = { 9, 2, 7, 1 };

            //Array.Sort(numbers2, (a, b) => a.CompareTo(b));

            //Console.WriteLine("Sorted with Lambda Expression:");
            //foreach (var n in numbers2) Console.WriteLine(n);

            #endregion

            #region P07
            //int a = 5, b = 10;
            //Console.WriteLine($"Before Swap: a={a}, b={b}");
            //SortingAlgorithm<int>.Swap(ref a, ref b);
            //Console.WriteLine($"After Swap: a={a}, b={b}");

            #endregion

            #region P08
            //Employee[] employees = {
            //new Employee { Name="Ali", Salary=4000 },
            //new Employee { Name="Sara", Salary=4000 },
            //new Employee { Name="Baha", Salary=4000 },
            //new Employee { Name="Omar", Salary=3000 }
            //};

            //SortingTwo<Employee> sorter = new SortingTwo<Employee>();
            //sorter.Sort(employees, (a, b) =>
            //{
            //    int result = a.Salary.CompareTo(b.Salary);
            //    return result == 0 ? a.Name.CompareTo(b.Name) : result;
            //});

            //Console.WriteLine("Employees sorted by Salary then Name:");
            //foreach (var e in employees) Console.WriteLine(e);

            #endregion

            #region P09
            //int defaultInt = GetDefault<int>();
            //string defaultStr = GetDefault<string>();

            //Console.WriteLine($"Default int: {defaultInt}");
            //Console.WriteLine($"Default string: {(defaultStr == null ? "null" : defaultStr)}");

            #endregion

            #region P10
            //EmployeeClone[] employees = {
            //new EmployeeClone { Name="Ali", Salary=5000 },
            //new EmployeeClone { Name="Sara", Salary=3000 }
            //};

            //SortingAlgorithm<EmployeeClone> sorter = new SortingAlgorithm<EmployeeClone>();
            //var cloned = sorter.CloneArray(employees);

            //Console.WriteLine("Cloned Employees:");
            //foreach (var e in cloned) Console.WriteLine(e);

            #endregion

            #region P11
            //List<string> words = new List<string> { "hello", "world" };

            //var upper = TransformStrings(words, s => s.ToUpper());
            //Console.WriteLine("Uppercase: " + string.Join(", ", upper));

            //var reversed = TransformStrings(words, s => new string(s.Reverse().ToArray()));
            //Console.WriteLine("Reversed: " + string.Join(", ", reversed));

            #endregion

            #region P12
            //Console.WriteLine("Addition: " + Perform(5, 3, (x, y) => x + y));
            //Console.WriteLine("Subtraction: " + Perform(5, 3, (x, y) => x - y));
            //Console.WriteLine("Multiplication: " + Perform(5, 3, (x, y) => x * y));
            //Console.WriteLine("Division: " + Perform(6, 3, (x, y) => x / y));

            #endregion

            #region P13
            //List<int> numbers = new List<int> { 1, 2, 3 };
            //var strings = Transform(numbers, x => x.ToString());

            //Console.WriteLine("Transformed Integers to Strings: " + string.Join(", ", strings));

            #endregion

            #region P14
            //List<int> numbers = new List<int> { 2, 3, 4 };
            //var squares = Apply(numbers, x => x * x);

            //Console.WriteLine("Squares: " + string.Join(", ", squares));

            #endregion

            #region P15
            //List<string> words = new List<string> { "C#", "AI", "OpenAI" };
            //Apply(words, s => Console.WriteLine("Word: " + s));

            #endregion

            #region P16
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 6 };
            //var evens = Filter(numbers, n => n % 2 == 0);

            //Console.WriteLine("Even Numbers: " + string.Join(", ", evens));

            #endregion

            #region P17
            //List<string> words = new List<string> { "apple", "banana", "cherry" };
            //var startsWithB = Filter(words, delegate (string s) { return s.StartsWith("b"); });

            //Console.WriteLine("Strings starting with 'b': " + string.Join(", ", startsWithB));


            #endregion

            #region P18
            //Func<int, int, int> add = delegate (int a, int b) { return a + b; };
            //Func<int, int, int> multiply = delegate (int a, int b) { return a * b; };

            //Console.WriteLine("Addition: " + add(4, 5));
            //Console.WriteLine("Multiplication: " + multiply(4, 5));

            #endregion

            #region P19
            //List<string> words = new List<string> { "car", "apple", "bike", "elephant" };
            //var filtered = Filter(words, s => s.Length > 3 && s.Contains("e"));

            //Console.WriteLine("Filtered Strings: " + string.Join(", ", filtered));

            #endregion

            #region P20
            //Func<double, double, double> divide = (a, b) => a / b;
            //Func<double, double, double> power = (a, b) => Math.Pow(a, b);

            //Console.WriteLine("Division: " + divide(10, 2));
            //Console.WriteLine("Exponentiation: " + power(2, 3));

            #endregion
        }
    }
}
