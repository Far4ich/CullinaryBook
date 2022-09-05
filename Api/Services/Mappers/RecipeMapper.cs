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
                recipe.Likes.Capacity);
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
                recipe.Likes.ConvertAll(x => x.MapToLikeDto()),
                recipe.Favorites.ConvertAll(x => x.MapToFavoriteDto()),
                recipe.Ingredients.ConvertAll(x => x.MapToIngredientDto()),
                recipe.Steps.ConvertAll(x => x.MapToStepDto()));
        }
        public static RecipeShortDto MapToRecipeShortDto(this Recipe recipe)
        {
            return new RecipeShortDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.NumberOfServings,
                recipe.Image,
                recipe.AuthorId,
                recipe.Tags.ConvertAll(x => x.MapToTagDto()),
                recipe.Likes.ConvertAll(x => x.MapToLikeDto()),
                recipe.Favorites.ConvertAll(x => x.MapToFavoriteDto()));
        }
    }
}
