using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
        }
        public Book(string title)
        {
            Title = title;
            Author = "Unknown Author";
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
}
