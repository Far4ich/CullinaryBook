using Domain.Recipe;

namespace Infrastructure.Data.RecipeModel
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public RecipeRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void Delete(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Recipe Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
