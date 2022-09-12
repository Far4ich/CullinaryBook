﻿using Domain.RecipeEntity;
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

        public async Task<RecipeBuilder> BuildAll(RecipeEditDto recipeDto)
        {
            _recipe = recipeDto.Id == 0
                ? new Recipe()
                : await _recipeRepository.Get(recipeDto.Id);

            if (_recipe == null)
            {
                throw new Exception($"{nameof(RecipeEditDto)} not found, #Id - {recipeDto.Id}");
            }
            _recipe.Id = recipeDto.Id;
            _recipe.Title = recipeDto.Title;
            _recipe.Description = recipeDto.Description;
            _recipe.CookingMinutes = recipeDto.CookingMinutes;
            _recipe.NumberOfServings = recipeDto.NumberOfServings;
            _recipe.Image = recipeDto.Image;
            _recipe.AuthorId = recipeDto.AuthorId;
            BuildIngredients(recipeDto);
            BuildSteps(recipeDto);
            Console.WriteLine("before tags");
            Dictionary<string, Tag> tags = (await _recipeRepository.GetTags()).ToDictionary(t => t.Title);
            Console.WriteLine("tags");
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
                    Console.WriteLine("Find " + tag.Title + $" id - {tag.Id}");
                    _recipe.Tags.Add(tag);
                }
                else
                {
                    Console.WriteLine("not Find " + tagDto.Title);
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
