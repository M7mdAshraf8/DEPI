using System.ComponentModel.DataAnnotations.Schema;

namespace Day23_task.Models
{
    public class StCrRes
    {
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        public int Grade { get; set; }
    }
}
