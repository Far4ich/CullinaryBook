using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Services.Builders
{
    public interface IRecipeBuilder
    {
        public void BuildMainData(RecipeDto recipeDto);
        public void BuildRelations(RecipeDto recipeDto);
        public Recipe GetResult();
    }
}
