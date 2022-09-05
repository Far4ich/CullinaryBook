using Api.Dto;

namespace Api.Services.Builders
{
    public class RecipeDirector
    {
        IRecipeBuilder recipeBuilder;

        public RecipeDirector(IRecipeBuilder recipeBuilder)
        {
            this.recipeBuilder = recipeBuilder;
        }

        public void Construct(RecipeDto recipeDto)
        {
            recipeBuilder.BuildMainData(recipeDto);
            recipeBuilder.BuildRelations(recipeDto);
        }
    }
}
