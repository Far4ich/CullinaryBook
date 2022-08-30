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

        public void Delete(int recipeId)
        {
            throw new NotImplementedException();
        }

        public Recipe Get(int recipeId)
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recipe GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetByTag(int tagId)
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

        public void SetTags(List<Tag> tags, int recipeId)
        {
            throw new NotImplementedException();
        }

        public void Update(Recipe recipe)
        {
            throw new NotImplementedException();
        }
    }
}
