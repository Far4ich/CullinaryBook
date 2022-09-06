using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Builders
{
    public interface IRecipeBuilder
    {
        RecipeBuilder BuildNewRecipe();
        RecipeBuilder BuildRecipeForUpdate(Recipe recipe);
        RecipeBuilder BuildIngredients(RecipeEditDto recipeDto);
        RecipeBuilder BuildRecipeData(RecipeEditDto recipeDto);
        RecipeBuilder BuildSteps(RecipeEditDto recipeDto);
        RecipeBuilder BuildTags(RecipeEditDto recipeDto);
        Recipe GetResult();
    }
}