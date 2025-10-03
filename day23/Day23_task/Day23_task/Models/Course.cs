using System.ComponentModel.DataAnnotations.Schema;

namespace Day23_task.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public int MinDegree { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public List<Teacher>? Teachers { get; set; }
        public List<StCrRes>? StCrRes { get; set; }
    }
}
