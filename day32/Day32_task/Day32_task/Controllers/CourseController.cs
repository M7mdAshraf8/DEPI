using Day32_task.Data.DbContexts;
using Day32_task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day32_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly SocietyDbContext context;

        public CourseController(SocietyDbContext context)
        {
            this.context = context;
        }

        // GET: api/Course
        [HttpGet]
        public IActionResult get()
        {
            List<Course> courses = context.Courses.ToList();
            if (courses == null || !courses.Any())
                return NotFound(); // 404

            return Ok(courses); // 200 
        }

        // GET: api/Course/id
        [HttpGet("{id:int}")]
        public IActionResult getById(int id)
        {
            Course course = context.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null)
                return NotFound(); // 404

            return Ok(course); // 200 
        }

        // GET: api/Course/Name
        [HttpGet("{name:alpha}")]
        public IActionResult couseByName(string name)
        {
            Course course = context.Courses.FirstOrDefault(c => c.Crs_name == name);
            if (course == null)
                return NotFound(); // 404

            return Ok(course); // 200 
        }

        // POST: api/Course
        [HttpPost]
        public IActionResult post(Course course)
        {
            if (course == null)
                return BadRequest(); // 400

            context.Courses.Add(course);
            context.SaveChanges();

            return CreatedAtAction(nameof(getById), new { id = course.Id }, course); // 201
        }

        // PUT: api/Course/id
        [HttpPut("{id}")]
        public IActionResult put(int id, Course course)
        {
            if (course == null || id != course.Id)
                return BadRequest(); // 400

            Course existingCourse = context.Courses.FirstOrDefault(c => c.Id == id);
            if (existingCourse == null)
                return NotFound(); // 404

            existingCourse.Crs_name = course.Crs_name;
            existingCourse.Crs_desc = course.Crs_desc;
            existingCourse.Duration = course.Duration;

            context.SaveChanges();

            return NoContent(); // 204
        }

        // DELETE: api/Course/id
        [HttpDelete("{id}")]
        public IActionResult deleteCourse(int id)
        {
            Course course = context.Courses.FirstOrDefault(c => c.Id == id);
            if (course == null)
                return NotFound(); // 404

            context.Courses.Remove(course);
            context.SaveChanges();

            var remainingCourses = context.Courses.ToList();
            return Ok(remainingCourses); // 200
        }
    }
}
