using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class RecipeController : Controller
    {
        [HttpGet]
        [Route("list")]
        public IActionResult GetRecipes()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
