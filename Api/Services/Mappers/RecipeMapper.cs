using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Mappers
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

        public static RecipeListDto MapToRecipeListDto(this Recipe recipe)
        {
            return new RecipeListDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.NumberOfServings,
                recipe.Image,
                recipe.Tags,
                recipe.Likes,
                recipe.Favorites);
        }

        public static RecipeFullDto MapToRecipeFullDto(this Recipe recipe)
        {
            return new RecipeFullDto(
                recipe.Id,
                recipe.Title,
                recipe.Description,
                recipe.CookingMinutes,
                recipe.NumberOfServings,
                recipe.Image,
                recipe.AuthorId,
                recipe.Tags,
                recipe.Likes,
                recipe.Favorites,
                recipe.Ingredients,
                recipe.Steps);
        }

        public static Recipe MapToRecipe(this RecipeFullDto recipeBestDto)
        {
            return new Recipe(
                recipeBestDto.Title,
                recipeBestDto.Description,
                recipeBestDto.CookingMinutes,
                recipeBestDto.NumberOfServings,
                recipeBestDto.Image,
                recipeBestDto.AuthorId)
            {
                Id = recipeBestDto.Id,
                Tags = recipeBestDto.Tags,
                Likes = recipeBestDto.Likes,
                Favorites = recipeBestDto.Favorites,
                Ingredients = recipeBestDto.Ingredients,
                Steps = recipeBestDto.Steps
            };
        }
    }
}
