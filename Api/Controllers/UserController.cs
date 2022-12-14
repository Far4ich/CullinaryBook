using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Api.Dto;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{userId}/likes")]
        public async Task<IActionResult> GetLikes(int userId)
        {
            return Ok(await _userService.GetLikes(userId));
        }

        [HttpGet]
        [Route("{userId}/favorites")]
        public async Task<IActionResult> GetFavorites(int userId)
        {
            return Ok(await _userService.GetFavorites(userId));
        }
    }
}
