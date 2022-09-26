using Domain.RecipeEntity;
using Api.Dto;
using Api.Services.Mappers;

namespace Api.Services.Builders
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe;
       
        private readonly IRecipeRepository _recipeRepository;
        private readonly IImageService _imageService;

        public RecipeBuilder(IRecipeRepository recipeRepository, IImageService imageService)
        {
            _recipeRepository = recipeRepository;
            _imageService = imageService;
        }

        public async Task<RecipeBuilder> BuildAll(RecipeEditDto recipeDto)
        {
            _recipe = recipeDto.Id == 0
                ? new Recipe()
                : await _recipeRepository.Get(recipeDto.Id);

            if (_recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found, #Id - {recipeDto.Id}");
            }
            _recipe.Id = recipeDto.Id;
            _recipe.Title = recipeDto.Title;
            _recipe.Description = recipeDto.Description;
            _recipe.CookingMinutes = recipeDto.CookingMinutes;
            _recipe.NumberOfServings = recipeDto.NumberOfServings;
            _recipe.AuthorId = recipeDto.AuthorId;

            if (!string.IsNullOrEmpty(_recipe.Image))
            {
                _imageService.DeleteImage(_recipe.Image);
            }
            _recipe.Image = await _imageService.SaveImage(recipeDto.Image);

            BuildIngredients(recipeDto);
            BuildSteps(recipeDto);
            Dictionary<string, Tag> tags = (await _recipeRepository.GetTags()).ToDictionary(t => t.Title);
            BuildTags(recipeDto, tags);

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

        private void BuildTags(RecipeEditDto recipeDto, Dictionary<string, Tag> tags)
        {
            _recipe.Tags = new();

            foreach (TagDto tagDto in recipeDto.Tags)
            {
                if (tags.TryGetValue(tagDto.Title, out Tag tag))
                {
                    _recipe.Tags.Add(tag);
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
