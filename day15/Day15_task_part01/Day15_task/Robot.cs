using Day15_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot walking with default behavior");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking as defined by IWalkable interface");
        }
    }
}
