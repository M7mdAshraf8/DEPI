using System;
using System.Drawing;
namespace Day13_task
{
    internal class Program
    {
        #region P6
        static void ModifyPoint(Point p)
        {
            p.X += 10;
            p.Y += 10;
        }

        static void ModifyEmployee(Employee emp)
        {
            emp.SetName(emp.GetName() + " Updated");
            emp.Salary += 1000;
        } 
        #endregion
        static void Main()
        {
            #region P1
            //Point p1 = new Point();          
            //Point p2 = new Point(3,5);      

            //Console.WriteLine(p1); 
            //Console.WriteLine(p2);  
            #endregion

            #region P2
            //TypeA obj = new TypeA(1, 2, 3);

            //Console.WriteLine(obj.G); 
            //Console.WriteLine(obj.H);  
            #endregion

            #region P3
            //Employee emp = new Employee(101, "John", 5000);

            //Console.WriteLine("Name : " + emp.GetName());
            //emp.SetName("Michael");
            //Console.WriteLine("Updated Name : " + emp.GetName());

            //Console.WriteLine("EmpId : " + emp.EmpId);
            //Console.WriteLine("Salary : " + emp.Salary);

            //emp.Salary = 6000;
            //Console.WriteLine("Updated Salary : " + emp.Salary); 
            #endregion

            #region P4
            //Point p1 = new Point(5);
            //Point p2 = new Point(3, 7);

            //Console.WriteLine(p1); 
            //Console.WriteLine(p2);  
            #endregion

            #region P5
            //Point p1 = new Point(5);
            //Point p2 = new Point(3, 7);
            //Point p3 = new Point(10, 20);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3); 
            #endregion

            #region P6
            //Point p1 = new Point(5, 5);
            //Console.WriteLine("Before ModifyPoint: " + p1);
            //ModifyPoint(p1);
            //Console.WriteLine("After ModifyPoint (unchanged): " + p1);

            //Console.WriteLine();

            //Employee e1 = new Employee(1, "Omar", 5000);
            //Console.WriteLine("Before ModifyEmployee: " + e1);
            //ModifyEmployee(e1);
            //Console.WriteLine("After ModifyEmployee (changed): " + e1); 
            #endregion
        }
    }
}
