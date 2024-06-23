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
    public class EnrolmentsController : ControllerBase
    {
        private readonly IEnrolmentService _enrolmentService;

        public EnrolmentsController(IEnrolmentService enrolmentService)
        {
            _enrolmentService = enrolmentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var enrolments = _enrolmentService.GetAll();
            return Ok(enrolments);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Enrolment enrolment)
        {
            if (enrolment == null)
            {
                return BadRequest("enrolment object is null");
            }

            var addedEnrolment = _enrolmentService.Add(enrolment);
            return CreatedAtAction(nameof(Get), new { id = addedEnrolment.EnrolmentId }, addedEnrolment);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Enrolment enrolment)
        {
            if (enrolment == null || id != enrolment.EnrolmentId)
            {
                return BadRequest("Invalid enrolment object or ID mismatch");
            }

            var existingEnrolment = _enrolmentService.GetById(id);
            if (existingEnrolment == null)
            {
                return NotFound($"Enrolment with ID {id} not found");
            }

            var updatedEnrolment = _enrolmentService.Update(enrolment);
            return Ok(updatedEnrolment);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingEnrolment = _enrolmentService.GetById(id);
            if (existingEnrolment == null)
            {
                return NotFound($"Enrolment with ID {id} not found");
            }

            _enrolmentService.Delete(id);
            return NoContent();
        }
    }
}
