using Domain.RecipeDto;
using Domain.RecipeEntity;

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

        public void Delete(int id)
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

        public RecipeTopDto GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public List<RecipeTopDto> GetByTag(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveFavorite(int recipeId, int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveLike(int recipeId, int userId)
        {
            throw new NotImplementedException();
        }

        public void SetFavorite(int recipeId, int userId)
        {
            throw new NotImplementedException();
        }

        public void SetLike(int recipeId, int userId)
        {
            throw new NotImplementedException();
        }

        public void SetTags(List<Tag> tags, int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
