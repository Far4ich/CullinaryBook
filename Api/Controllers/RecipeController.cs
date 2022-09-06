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
        public async Task<IActionResult> GetRecipe(int recipeId)
        {
            return Ok(await _recipeService.Get(recipeId));
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> GetRecipeList()
        {
            return Ok(await _recipeService.GetAll());
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateRecipe([FromBody]RecipeEditDto recipe)
        {
            await _recipeService.Create(recipe);
            return Ok();
        }

        [HttpDelete]
        [Route("{recipeId}")]
        public async Task<IActionResult> DeleteRecipes(int recipeId)
        {
            await _recipeService.Delete(recipeId);
            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateRecipes([FromBody] RecipeEditDto recipe)
        {
            await _recipeService.Update(recipe);
            return Ok();
        }
    }
}
