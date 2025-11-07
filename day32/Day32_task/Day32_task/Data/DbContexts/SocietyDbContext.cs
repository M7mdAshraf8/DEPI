using Day32_task.Models;
using Microsoft.EntityFrameworkCore;

namespace Day32_task.Data.DbContexts
{
    public class SocietyDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public SocietyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
