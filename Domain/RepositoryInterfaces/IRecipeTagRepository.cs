using Domain.Models;

namespace Domain.RepositoryInterfaces
{
    public interface IRecipeTagRepository
    {
        List<RecipeTag> GetRecipeTagsByRecipeId(int recipeId);
        void Delete(RecipeTag recipeTag);
        void Create(RecipeTag recipeTag);
    }
}
