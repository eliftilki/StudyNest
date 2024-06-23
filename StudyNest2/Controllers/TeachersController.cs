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
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var teachers = _teacherService.GetAll();
            return Ok(teachers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Teacher teacher)
        {
            if (teacher == null)
            {
                return BadRequest("TEACHER object is null");
            }

            var addedTeacher = _teacherService.Add(teacher);
            return CreatedAtAction(nameof(Get), new { id = addedTeacher.TeacherId }, addedTeacher);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Teacher teacher)
        {
            if (teacher == null || id != teacher.TeacherId)
            {
                return BadRequest("Invalid teacher object or ID mismatch");
            }

            var existingTeacher = _teacherService.GetById(id);
            if (existingTeacher == null)
            {
                return NotFound($"Teacher with ID {id} not found");
            }

            var updatedTeacher = _teacherService.Update(teacher);
            return Ok(updatedTeacher);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingTeacher = _teacherService.GetById(id);
            if (existingTeacher == null)
            {
                return NotFound($"Teacher with ID {id} not found");
            }

            _teacherService.Delete(id);
            return NoContent();
        }
    }
}
