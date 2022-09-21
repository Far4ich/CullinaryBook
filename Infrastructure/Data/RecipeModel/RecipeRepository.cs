using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.RecipeModel
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly CullinaryBookContext _dbContext;
        public RecipeRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Recipe recipe)
        {
            await _dbContext.Recipe.AddAsync(recipe);
        }

        public void Delete(Recipe recipe)
        {
            _dbContext.Recipe.Remove(recipe);
        }

        public async Task<Recipe> Get(int recipeId)
        {
            return await _dbContext.Recipe
                .Where(recipe => recipe.Id == recipeId)
                .Include(recipe => recipe.Tags)
                .Include(recipe => recipe.RecipeTags)
                .Include(recipe => recipe.Ingredients)
                .Include(recipe => recipe.Steps)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Recipe>> GetRecipes()
        {
            return await _dbContext.Recipe
                .Include(recipe => recipe.Tags)
                .Include(recipe => recipe.RecipeTags)
                .Include(recipe => recipe.Likes)
                .Include(recipe => recipe.Favorites)
                .ToListAsync();
        }

        public async Task<List<Tag>> GetTags()
        {
            return await _dbContext.Tag.ToListAsync();
        }
        //по макс лайкам
        public Recipe GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public List<Recipe> GetByTag(int tagId)
        {
            throw new NotImplementedException();
        }
        public async Task<Favorite> GetFavorite(int recipeId, int userId)
        {
            return await _dbContext.Favorite.SingleOrDefaultAsync(
                x => x.RecipeId == recipeId && x.UserId == userId);
        }

        public async Task<Like> GetLike(int recipeId, int userId)
        {
            return await _dbContext.Like.SingleOrDefaultAsync(
                x => x.RecipeId == recipeId && x.UserId == userId);
        }
        public void RemoveFavorite(Favorite favorite)
        {
            _dbContext.Favorite.Remove(favorite);
        }

        public void RemoveLike(Like like)
        {
            _dbContext.Like.Remove(like);
        }

        public async Task AddFavorite(Favorite favorite)
        {
            await _dbContext.Favorite.AddAsync(favorite);
        }

        public async Task AddLike(Like like)
        {
            await _dbContext.Like.AddAsync(like);
        }
    }
}
