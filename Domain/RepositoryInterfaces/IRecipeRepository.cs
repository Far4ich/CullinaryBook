using Domain.Models;

namespace Domain.RepositoryInterfaces
{
    public interface IRecipeRepository
    {
        List<Recipe> GetAll();
        Recipe Get(int id);
        void Update(Recipe recipe);
        void Create(Recipe recipe);
        void Delete(Recipe recipe);
    }
}
