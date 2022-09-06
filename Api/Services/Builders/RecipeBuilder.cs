using Domain.RecipeEntity;
using Api.Dto;
using Api.Services.Mappers;

namespace Api.Services.Builders
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe;

        public RecipeBuilder BuildNewRecipe()
        {
            _recipe = new Recipe();
            return this;
        }
        public RecipeBuilder BuildRecipeData(RecipeEditDto recipeDto)
        {
            _recipe.Id = recipeDto.Id;
            _recipe.Title = recipeDto.Title;
            _recipe.Description = recipeDto.Description;
            _recipe.CookingMinutes = recipeDto.CookingMinutes;
            _recipe.NumberOfServings = recipeDto.NumberOfServings;
            _recipe.Image = recipeDto.Image;
            _recipe.AuthorId = recipeDto.AuthorId;
            return this;
        }
        
        public RecipeBuilder BuildRecipeForUpdate(Recipe recipe)
        {
            _recipe = recipe;
            return this;
        }

        public RecipeBuilder BuildIngredients(RecipeEditDto recipeDto)
        {
            _recipe.Ingredients = recipeDto.IngredientDtos.ConvertAll(x => x.MapToIngredient());
            return this;
        }
        public RecipeBuilder BuildSteps(RecipeEditDto recipeDto)
        {
            _recipe.Steps = recipeDto.StepDtos.ConvertAll(x => x.MapToStep());
            return this;
        }

        public RecipeBuilder BuildTags(RecipeEditDto recipeDto)
        {
            _recipe.Tags = recipeDto.TagDtos.ConvertAll(x => x.MapToTag());
            return this;
        }

        public Recipe GetResult()
        {
            return _recipe;
        }
    }
}
