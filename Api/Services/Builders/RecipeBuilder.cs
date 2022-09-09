using Domain.RecipeEntity;
using Api.Dto;
using Api.Services.Mappers;

namespace Api.Services.Builders
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe;
        private readonly IRecipeRepository _recipeRepository;

        public RecipeBuilder(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public RecipeBuilder Build()
        {
            _recipe = new Recipe();
            return this;
        }

        public RecipeBuilder Build(Recipe recipe)
        {
            _recipe = recipe;
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
            BuildIngredients(recipeDto);
            BuildSteps(recipeDto);
            BuildTags(recipeDto);
            return this;
        }

        private void BuildIngredients(RecipeEditDto recipeDto)
        {
            _recipe.Ingredients = recipeDto.Ingredients.ConvertAll(x => x.MapToIngredient());
        }
        private void BuildSteps(RecipeEditDto recipeDto)
        {
            _recipe.Steps = recipeDto.Steps.ConvertAll(x => x.MapToStep());
        }

        private async void BuildTags(RecipeEditDto recipeDto)
        {
            List<Tag> tags = await _recipeRepository.GetTags();
            _recipe.Tags = new();

            foreach (TagDto tagDto in recipeDto.Tags)
            {
                Tag tagTmp = tags.Find(x => x.Title == tagDto.Title);
                if (tagTmp != null)
                {
                    _recipe.Tags.Add(tagTmp);
                }
                else
                {
                    _recipe.Tags.Add(tagDto.MapToTag());
                }
            }
        }

        public Recipe GetResult()
        {
            return _recipe;
        }
    }
}
