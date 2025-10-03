using Day15_task.Interfaces;
using System;

namespace Day15_task
{
    internal class Program
    {
        static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
            Console.WriteLine("--------------");
        }
        public static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
        static void Main()
        {
            #region P1
            //Console.WriteLine("Square Series:");
            //PrintTenShapes(new SquareSeries());

            //Console.WriteLine("Circle Series:");
            //PrintTenShapes(new CircleSeries()); 
            #endregion

            #region P2
            //Shape[] shapes =
            //{
            //    new Shape("Square", 25),
            //    new Shape("Circle", Math.PI*4*4),
            //    new Shape("Rectangle", 30),
            //    new Shape("Circle", Math.PI*2*2),
            //    new Shape("Square", 100)
            //};

            //Console.WriteLine("Before Sorting : ");
            //foreach (var shape in shapes)
            //    shape.Display();

            //Array.Sort(shapes);

            //Console.WriteLine("\nAfter Sorting (Ascending by Area) : ");
            //foreach (var shape in shapes)
            //    shape.Display(); 
            #endregion

            #region P3
            //GeometricShape t = new Triangle(3, 4);
            //GeometricShape r = new Rectangle(5, 7);

            //t.Display();
            //Console.WriteLine("--------------");
            //r.Display(); 
            #endregion

            #region P4
            //int[] areas = new int[10];
            //for (int i = 0; i < areas.Length; i++)
            //{
            //    int side = i + 1; 
            //    areas[i] = side * side;
            //}
            //Console.WriteLine("Original Areas:");
            //PrintArray(areas);

            //Random rand = new Random();
            //for (int i = 0; i < areas.Length; i++)
            //{
            //    int r = rand.Next(areas.Length);
            //    int temp = areas[i];
            //    areas[i] = areas[r];
            //    areas[r] = temp;
            //}
            //Console.WriteLine("\nShuffled Areas:");
            //PrintArray(areas);

            //SelectionSort(areas);
            //Console.WriteLine("\nSorted Areas (Ascending):");
            //PrintArray(areas);
            #endregion

            #region P5
            //ShapeFactory factory = new ShapeFactory();

            //GeometricShape rect = factory.CreateShape("rectangle", 10, 5);
            //GeometricShape tri = factory.CreateShape("triangle", 6, 4);

            //rect.Display();
            //tri.Display(); 
            #endregion
        }
    }
}
