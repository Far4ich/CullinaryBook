using Domain.RecipeEntity;
using Api.Dto;
using Api.Services.Mappers;

namespace Api.Services.Builders
{
    public class RecipeBuilder : IRecipeBuilder
    {
        private Recipe _recipe;
        private readonly string _imagesPath = "C:\\Users\\Alex\\Desktop\\Practice\\SaveImages";
        private readonly IRecipeRepository _recipeRepository;

        public RecipeBuilder(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
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
            await BuildImage(recipeDto.Image);
            _recipe.AuthorId = recipeDto.AuthorId;
            BuildIngredients(recipeDto);
            BuildSteps(recipeDto);
            Dictionary<string, Tag> tags = (await _recipeRepository.GetTags()).ToDictionary(t => t.Title);
            BuildTags(recipeDto, tags);

            return this;
        }

        private async Task BuildImage(string image)
        {
            string imageFormat = image[(image.IndexOf("/") + 1)..image.IndexOf(";")];
            string imageName = Path.ChangeExtension(Path.GetRandomFileName(), imageFormat);
            string imagePath = Path.Combine(_imagesPath, imageName);

            byte[] bytes = Convert.FromBase64String(image[(image.IndexOf(",") + 1)..]);
            FileStream fs = new(imagePath, FileMode.Create);
            await fs.WriteAsync(bytes);
            fs.Close();

            if (!string.IsNullOrEmpty(_recipe.Image))
            {
                string deleteImgPath = Path.Combine(_imagesPath, _recipe.Image);
                if (File.Exists(deleteImgPath))
                {
                    File.Delete(deleteImgPath);
                }
            }

            _recipe.Image = imageName;
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
