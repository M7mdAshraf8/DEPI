using Day24_task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Day24_task.Models
{
    public class DepartmentBL
    {
        SchoolDbContext context = new SchoolDbContext();

        public List<Department> GetAll()
        {
            return context.Departments
                          .Include(d => d.Students)
                          .ToList();
        }

        public Department? GetById(int id)
        {
            return context.Departments
                          .Include(d => d.Students)
                          .FirstOrDefault(d => d.Id == id);
        }

        public void AddDept(Department dept)
        {
            context.Departments.Add(dept);
            context.SaveChanges();
        }
        public void SaveInDB()
        {
            context.SaveChanges();
        }
    }
}
