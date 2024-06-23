using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudyNest2.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var courses = _courseService.GetAll();
            return Ok(courses);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Course course)
        {
            if (course == null)
            {
                return BadRequest("Course object is null");
            }

            var addedCourse = _courseService.Add(course);
            return CreatedAtAction(nameof(Get), new { id = addedCourse.CourseId }, addedCourse);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Course course)
        {
            if (course == null || id != course.CourseId)
            {
                return BadRequest("Invalid course object or ID mismatch");
            }

            var existingCourse = _courseService.GetById(id);
            if (existingCourse == null)
            {
                return NotFound($"Course with ID {id} not found");
            }

            var updatedCourse = _courseService.Update(course);
            return Ok(updatedCourse);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingCourse = _courseService.GetById(id);
            if (existingCourse == null)
            {
                return NotFound($"Course with ID {id} not found");
            }

            _courseService.Delete(id);
            return NoContent();
        }
        [HttpGet("ByCategory/{categoryId}")]
        public IActionResult GetByCategory(short categoryId)
        {
            var courses = _courseService.GetCoursesByCategoryId(categoryId);
            return Ok(courses);
        }

        [HttpGet("ByCorseId/{id}")]
        public IActionResult GetByCategory(int id)
        {
            var course = _courseService.GetById(id);
            return Ok(course);
        }
    }
}
