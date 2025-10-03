using Day23_task.Models;
using Microsoft.EntityFrameworkCore;

namespace Day23_task.Data.DbContexts
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SchoolDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StCrRes> StCrRes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StCrRes>()
                .HasKey(s => new { s.StudentId, s.CourseId });

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Teachers)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Course)
                .WithMany(c => c.Teachers)
                .HasForeignKey(t => t.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StCrRes>()
                .HasOne(s => s.Student)
                .WithMany(st => st.StCrRes)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Cascade);  

            modelBuilder.Entity<StCrRes>()
                .HasOne(s => s.Course)
                .WithMany(c => c.StCrRes)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.Restrict);  
        }
    }
}
