using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Mappers
{
    public class RecipeMapper
    {
        public RecipeTopDto MapToRecipeTopDto(Recipe recipe)
        {
            return new RecipeTopDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.NumberOfServings,
                recipe.Image,
                recipe.AuthorId);
        }
    }
}
