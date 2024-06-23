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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var categories = _categoryService.GetAll();
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest("Category object is null");
            }

            var addedCategory = _categoryService.Add(category);
            return CreatedAtAction(nameof(Get), new { id = addedCategory.CategoryId }, addedCategory);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            if (category == null || id != category.CategoryId)
            {
                return BadRequest("Invalid category object or ID mismatch");
            }

            var existingCategory = _categoryService.GetById(id);
            if (existingCategory == null)
            {
                return NotFound($"Category with ID {id} not found");
            }

            var updatedCategory = _categoryService.Update(category);
            return Ok(updatedCategory);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingCategory = _categoryService.GetById(id);
            if (existingCategory == null)
            {
                return NotFound($"Category with ID {id} not found");
            }

            _categoryService.Delete(id);
            return NoContent();
        }
    }
}
