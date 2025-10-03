using Day24_task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Day24_task.Models
{
    public class StudentBL
    {
        SchoolDbContext context = new SchoolDbContext();

        public List<Student> GetAll()
        {
            return context.Students.Include(s => s.Department).ToList();
        }

        public Student GetById(int id)
        {
        return context.Students
                      .Include(s => s.Department)
                      .Include(s => s.StCrRes)
                          .ThenInclude(sc => sc.Course)
                      .FirstOrDefault(s => s.Id == id);
        }
    }
}
