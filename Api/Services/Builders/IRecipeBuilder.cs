using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Builders
{
    public interface IRecipeBuilder
    {
        RecipeBuilder Build();
        RecipeBuilder Build(Recipe recipe);
        RecipeBuilder BuildRecipeData(RecipeEditDto recipeDto);
        Recipe GetResult();
    }
}