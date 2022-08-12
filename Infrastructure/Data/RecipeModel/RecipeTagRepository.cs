using Domain.Recipe;

namespace Infrastructure.Data.RecipeModel
{
    public class RecipeTagRepository : IRecipeTagRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public RecipeTagRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(RecipeTag recipeTag)
        {
            throw new NotImplementedException();
        }

        public void Delete(RecipeTag recipeTag)
        {
            throw new NotImplementedException();
        }

        public List<RecipeTag> GetRecipeTagsByRecipeId(int recipeId)
        {
            throw new NotImplementedException();
        }
    }
}
