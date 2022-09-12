using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Builders
{
    public interface IRecipeBuilder
    {
        Task<RecipeBuilder> BuildAll(RecipeEditDto recipeDto);
        Recipe GetResult();
    }
}