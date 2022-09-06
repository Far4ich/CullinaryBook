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

        //перекинуть в сервис добавить проверку на null
        public async Task Delete(int recipeId)
        {
            Recipe recipe = await Get(recipeId);
            _dbContext.Recipe.Remove(recipe);
        }

        public async Task<Recipe> Get(int recipeId)
        {
            var recipe = await _dbContext.Recipe
                .Where(recipe => recipe.Id == recipeId)
                .Include(recipe => recipe.Tags)
                .Include(recipe => recipe.RecipeTags)
                .Include(recipe => recipe.Ingredients)
                .Include(recipe => recipe.Steps)
                .Include(recipe => recipe.Author)
                .Include(recipe => recipe.Likes)
                .Include(recipe => recipe.Favorites)
                .FirstOrDefaultAsync();
            return recipe;
        }

        public async Task<List<Recipe>> GetAll()
        {
            return await _dbContext.Recipe
                .Include(recipe => recipe.Tags)
                .Include(recipe => recipe.RecipeTags)
                .Include(recipe => recipe.Author)
                .Include(recipe => recipe.Likes)
                .Include(recipe => recipe.Favorites)
                .ToListAsync();
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

        //перекинуть в сервис, добавить проверку на null
        public async Task RemoveFavorite(int recipeId, int userId)
        {
            var favorite = await _dbContext.Favorite
                .SingleOrDefaultAsync(favorite => favorite.RecipeId == recipeId && favorite.UserId == userId);
            _dbContext.Favorite.Remove(favorite);
        }

        //перекинуть в сервис, добавить проверку на null
        public async Task RemoveLike(int recipeId, int userId)
        {
            var like = await _dbContext.Like
                .SingleOrDefaultAsync(like => like.RecipeId == recipeId && like.UserId == userId);
            _dbContext.Like.Remove(like);
        }

        public async Task SetFavorite(int recipeId, int userId)
        {
            await _dbContext.Favorite.AddAsync(new Favorite(userId, recipeId));
        }

        public async Task SetLike(int recipeId, int userId)
        {
            await _dbContext.Like.AddAsync(new Like(userId, recipeId));
        }

        public void Update(Recipe recipe)
        {
            _dbContext.Recipe.Update(recipe);
        }
    }
}
