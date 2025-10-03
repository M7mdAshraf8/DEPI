using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_task.Models.Library_System
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public List<Loan> Loans { get; set; }
    }
}
