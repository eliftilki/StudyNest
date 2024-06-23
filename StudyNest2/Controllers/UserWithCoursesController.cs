using Business.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace StudyNest2.Controllers
{

    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserWithCoursesController : ControllerBase
    {
        private readonly IUserWithCoursesService _userWithCoursesService;

        public UserWithCoursesController(IUserWithCoursesService userWithCoursesService)
        {
            _userWithCoursesService = userWithCoursesService;
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetUserWithCoursesByEmail(string email)
        {
            var userWithCourses = await _userWithCoursesService.GetUserWithCoursesByEmailAsync(email);
            //if (userWithCourses == null)
            //{
            //    return NotFound("Belirtilen e-posta adresine sahip bir kullanıcı bulunamadı.");
            //}
            if (userWithCourses == null)
            {
                return Ok();
            }
            return Ok(userWithCourses);
        }
    }
}