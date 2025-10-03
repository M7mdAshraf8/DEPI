using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_task.Models.Library_System
{
    internal class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }

        public List<Loan> Loans { get; set; }
    }
}
