using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Builders
{
    public interface IRecipeBuilder
    {
        RecipeBuilder BuildNewRecipe();
        RecipeBuilder BuildRecipeForUpdate(Recipe recipe);
        RecipeBuilder BuildRecipeData(RecipeEditDto recipeDto);
        Recipe GetResult();
    }
}