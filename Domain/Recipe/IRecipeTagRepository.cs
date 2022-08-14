namespace Domain.Recipe
{
    public interface IRecipeTagRepository
    {
        List<RecipeTag> GetRecipeTagsByRecipeId(int recipeId);
    }
}
