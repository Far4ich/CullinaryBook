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
            _dbContext.Recipe.Add(recipe);
        }

        public void Delete(int recipeId)
        {
            _dbContext.Recipe.Remove(Get(recipeId));
        }

        public Recipe Get(int recipeId)
        {
            return _dbContext.Recipe.SingleOrDefault(recipe => recipe.Id == recipeId);
        }

        public List<Recipe> GetAll()
        {
            return _dbContext.Recipe.ToList();
        }

        public Recipe GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetByTag(int tagId)
        {
            return (List<Recipe>)_dbContext.Recipe.Where(recipe => recipe.Tags.Find(t => t.Id == tagId) != null);
        }
         
        public void RemoveFavorite(int recipeId, int userId)
        {
            _dbContext.Favorite.Remove(_dbContext.Favorite.SingleOrDefault(favorite =>
                favorite.RecipeId == recipeId && favorite.UserId == userId));
        }

        public void RemoveLike(int recipeId, int userId)
        {
            _dbContext.Like.Remove(_dbContext.Like.SingleOrDefault(like =>
                like.RecipeId == recipeId && like.UserId == userId));
        }

        public void SetFavorite(int recipeId, int userId)
        {
            _dbContext.Favorite.Add(new Favorite(0, userId, recipeId));
        }

        public void SetLike(int recipeId, int userId)
        {
            _dbContext.Like.Add(new Like(0, userId, recipeId));
        }

        public void Update(Recipe recipe)
        {
            _dbContext.Recipe.Update(recipe);
        }
    }
}
