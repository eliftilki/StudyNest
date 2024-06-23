using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace StudyNest2.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User object is null");
            }
            var existingUser = _userService.GetByEmail(user.Email);
            if (existingUser != null)
            {
                // Kullanıcı zaten mevcut olduğu için false dön
                return Ok(false);
            }

            var addedUser = _userService.Add(user);
            return CreatedAtAction(nameof(Get), new { id = addedUser.UserId }, addedUser);
            
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            if (user == null || id != user.UserId)
            {
                return BadRequest("Invalid user object or ID mismatch");
            }

            var existingUser = _userService.GetById(id);
            if (existingUser == null)
            {
                return NotFound($"User with ID {id} not found");
            }

            var updatedUser = _userService.Update(user);
            return Ok(updatedUser);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingUser = _userService.GetById(id);
            if (existingUser == null)
            {
                return NotFound($"User with ID {id} not found");
            }

            _userService.Delete(id);
            return NoContent();
        }


    }
}
