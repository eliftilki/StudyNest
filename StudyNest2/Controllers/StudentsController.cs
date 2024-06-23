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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentService.GetAll();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            if (student == null)
            {
                return BadRequest("student object is null");
            }

            var addedStudent = _studentService.Add(student);
            return CreatedAtAction(nameof(Get), new { id = addedStudent.StudentId }, addedStudent);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            if (student == null || id != student.StudentId)
            {
                return BadRequest("Invalid student object or ID mismatch");
            }

            var existingStudent = _studentService.GetById(id);
            if (existingStudent == null)
            {
                return NotFound($"Student with ID {id} not found");
            }

            var updatedStudent = _studentService.Update(student);
            return Ok(updatedStudent);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingStudent = _studentService.GetById(id);
            if (existingStudent == null)
            {
                return NotFound($"Student with ID {id} not found");
            }

            _studentService.Delete(id);
            return NoContent();
        }
    }
}
