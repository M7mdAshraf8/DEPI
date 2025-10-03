using Day15_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Car : IMovable,IVehicle
    {
        public void Move()
        {
            Console.WriteLine("The car is moving on the road...");
        }
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
