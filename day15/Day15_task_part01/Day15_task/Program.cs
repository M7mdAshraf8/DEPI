using Day15_task.Interfaces;
using System;

namespace Day15_task
{
    internal class Program
    {
        static void Main()
        {
            /*------------------------------ Task 07 Part01 ------------------------------*/
            #region P6
            //Rectangle shape = new Rectangle(5, 10);
            //shape.Draw(); 
            #endregion

            #region P7
            //IShape shape = new Circle(5);
            //shape.Draw();
            //shape.PrintDetails();  
            #endregion

            #region P8
            //IMovable movable = new Car();
            //movable.Move(); 
            #endregion

            #region P9
            //File file = new File();

            //file.Read();
            //file.Write();

            //IReadable reader = file;
            //reader.Read();

            //IWritable writer = file;
            //writer.Write(); 
            #endregion

            #region P10
            //Shape rect = new Rectangle2(5, 10);
            //Console.WriteLine("Area = " + rect.CalculateArea()); 
            #endregion
            /*------------------------------ Task 08 Part01 ------------------------------*/
            #region P1
            //IVehicle vehicle1 = new Car();
            //IVehicle vehicle2 = new Bike();

            //vehicle1.StartEngine();
            //vehicle1.StopEngine();

            //vehicle2.StartEngine();
            //vehicle2.StopEngine(); 
            #endregion

            #region P2
            //Shape rect = new Rectangle(5, 10);
            //rect.Display();
            //Console.WriteLine("Rectangle Area = " + rect.GetArea());

            //Shape circle = new Circle(4);
            //circle.Display();
            //Console.WriteLine("Circle Area = " + circle.GetArea());

            //IShape irect = new RectangleInterface(5, 10);
            //Console.WriteLine("Rectangle (interface) Area = " + irect.GetArea()); 
            #endregion

            #region P3
            //Product[] products =
            //{
            //    new Product(1, "Laptop", 1200),
            //    new Product(2, "Phone", 800),
            //    new Product(3, "Tablet", 500),
            //    new Product(4, "Monitor", 300)
            //};
            //Array.Sort(products);

            //Console.WriteLine("Products sorted by Price:");
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region P4
            //Student s1 = new Student(1, "Ali", 90);

            //Student shallowCopy = s1;

            //Student deepCopy = new Student(s1);

            //Console.WriteLine("Before modification:");
            //Console.WriteLine("Original: " + s1);
            //Console.WriteLine("Shallow: " + shallowCopy);
            //Console.WriteLine("Deep: " + deepCopy);

            //s1.Grade = 50;

            //Console.WriteLine("\nAfter modifying original:");
            //Console.WriteLine("Original: " + s1);
            //Console.WriteLine("Shallow: " + shallowCopy);
            //Console.WriteLine("Deep: " + deepCopy); 
            #endregion

            #region P5
            //Robot r = new Robot();

            //r.Walk();

            //IWalkable walkable = r;
            //walkable.Walk(); 
            #endregion

            #region P6
            //Account acc1 = new Account(101, "Ali", 5000);

            //acc1.Balance = 6000;

            //acc1.Display(); 
            #endregion

            #region P7
            //ILogger logger = new ConsoleLogger();
            //logger.Log("Application started "); 

            //ILogger defaultLogger = new DefaultLogger();
            //defaultLogger.Log("This is default implementation");
            #endregion

            #region P8
            //Book b1 = new Book();
            //Book b2 = new Book("C# in Depth");
            //Book b3 = new Book("Clean Code", "Robert C. Martin"); 

            //b1.Display();
            //b2.Display();
            //b3.Display(); 
            #endregion

        }
    }
}
