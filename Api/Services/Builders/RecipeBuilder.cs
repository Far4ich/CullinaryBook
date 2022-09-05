using Domain.RecipeEntity;
using Api.Dto;
using Api.Services.Mappers;

namespace Api.Services.Builders
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe recipe;

        public void BuildMainData(RecipeDto recipeDto)
        {
            recipe = new Recipe(
                recipeDto.Title,
                recipeDto.Description,
                recipeDto.CookingMinutes,
                recipeDto.NumberOfServings,
                recipeDto.Image,
                recipeDto.AuthorId);
        }

        public void BuildRelations(RecipeDto recipeDto)
        {
            recipe.Ingredients = recipeDto.IngredientDtos.ConvertAll(x => x.MapToIngredient());       
            recipe.Steps = recipeDto.StepDtos.ConvertAll(x => x.MapToStep());       
            recipe.Tags = recipeDto.TagDtos.ConvertAll(x => x.MapToTag());
            recipe.Likes = recipeDto.LikeDtos.ConvertAll(x => x.MapToLike());
            recipe.Favorites = recipeDto.FavoriteDtos.ConvertAll(x => x.MapToFavorite());
        }

        public Recipe GetResult()
        {
            return recipe;
        }
    }
}
