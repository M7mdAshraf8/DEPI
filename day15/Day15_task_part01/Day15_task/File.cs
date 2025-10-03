using Day15_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading data from the file...");
        }

        public void Write()
        {
            Console.WriteLine("Writing data to the file...");
        }
    }
}
