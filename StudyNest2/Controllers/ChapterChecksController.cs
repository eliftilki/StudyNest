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
    public class ChapterChecksController : ControllerBase
    {
        private readonly IChapterCheckService _chapterCheckService;

        public ChapterChecksController(IChapterCheckService chapterCheckService)
        {
            _chapterCheckService = chapterCheckService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var chapterChecks = _chapterCheckService.GetAll();
            return Ok(chapterChecks);
        }

        [HttpPost]
        public IActionResult Post([FromBody] ChapterCheck chapterCheck)
        {
            if (chapterCheck == null)
            {
                return BadRequest("ChapterCheck object is null");
            }

            var addedChapterCheck = _chapterCheckService.Add(chapterCheck);
            return CreatedAtAction(nameof(Get), new { id = addedChapterCheck.ChapterCheckId }, addedChapterCheck);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ChapterCheck chapterCheck)
        {
            if (chapterCheck == null || id != chapterCheck.ChapterCheckId)
            {
                return BadRequest("Invalid chapterCheck object or ID mismatch");
            }

            var existingChapterCheck = _chapterCheckService.GetById(id);
            if (existingChapterCheck == null)
            {
                return NotFound($"ChapterCheck with ID {id} not found");
            }

            var updatedChapterCheck = _chapterCheckService.Update(chapterCheck);
            return Ok(updatedChapterCheck);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingChapterCheck = _chapterCheckService.GetById(id);
            if (existingChapterCheck == null)
            {
                return NotFound($"ChapterCheck with ID {id} not found");
            }

            _chapterCheckService.Delete(id);
            return NoContent();
        }
    }
}
