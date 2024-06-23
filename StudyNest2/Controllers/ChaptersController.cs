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
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterService _chapterService;

        public ChaptersController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var chapters = _chapterService.GetAll();
            return Ok(chapters);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Chapter chapter)
        {
            if (chapter == null)
            {
                return BadRequest("Chapter object is null");
            }

            var addedChapter = _chapterService.Add(chapter);
            return CreatedAtAction(nameof(Get), new { id = addedChapter.ChapterId }, addedChapter);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Chapter chapter)
        {
            if (chapter == null || id != chapter.ChapterId)
            {
                return BadRequest("Invalid chapter object or ID mismatch");
            }

            var existingChapter = _chapterService.GetById(id);
            if (existingChapter == null)
            {
                return NotFound($"Chapter with ID {id} not found");
            }

            var updatedChapter = _chapterService.Update(chapter);
            return Ok(updatedChapter);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingChapter = _chapterService.GetById(id);
            if (existingChapter == null)
            {
                return NotFound($"Chapter with ID {id} not found");
            }

            _chapterService.Delete(id);
            return NoContent();
        }
        [HttpGet("ByCourse/{courseId}")]
        public IActionResult GetByCategory(int courseId)
        {
            var chapters = _chapterService.GetChaptersByCourseId(courseId);
            return Ok(chapters);
        }
    }
}
