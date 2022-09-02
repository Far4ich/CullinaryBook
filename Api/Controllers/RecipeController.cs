using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Api.Dto;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet]
        [Route("{recipeId}")]
        public IActionResult GetRecipe(int recipeId)
        {
            return Ok(_recipeService.Get(recipeId));
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetRecipeList()
        {
            return Ok(_recipeService.GetAll());
        }

        [HttpPost]
        [Route("create")]
        public IActionResult CreateRecipes([FromBody]RecipeFullDto recipe)
        {
            _recipeService.Create(recipe);
            return Ok();
        }

        [HttpDelete]
        [Route("{recipeId}")]
        public IActionResult DeleteRecipes(int recipeId)
        {
            _recipeService.Delete(recipeId);
            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public IActionResult UpdateRecipes([FromBody] RecipeFullDto recipe)
        {
            _recipeService.Update(recipe);
            return Ok();
        }
    }
}
