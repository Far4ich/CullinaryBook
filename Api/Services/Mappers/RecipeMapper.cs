using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Services.Mappers
{
    public static class RecipeMapper
    {
        public static RecipeBestDto MapToRecipeBestDto(this Recipe recipe)
        {
            return new RecipeBestDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.Image,
                recipe.Likes.Count());
        }

        public static RecipeEditDto MapToRecipeEditDto(this Recipe recipe)
        {
            return new RecipeEditDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.NumberOfServings,
                recipe.Image,
                recipe.AuthorId,
                recipe.Tags.ConvertAll(x => x.MapToTagDto()),
                recipe.Ingredients.ConvertAll(x => x.MapToIngredientDto()),
                recipe.Steps.ConvertAll(x => x.MapToStepDto()));
        }
        public static RecipeDto MapToRecipeDto(this Recipe recipe)
        {
            return new RecipeDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.NumberOfServings,
                recipe.Image,
                recipe.AuthorId,
                recipe.Tags.ConvertAll(x => x.MapToTagDto()),
                recipe.Likes.Count(),
                recipe.Favorites.Count());
        }
    }
}
