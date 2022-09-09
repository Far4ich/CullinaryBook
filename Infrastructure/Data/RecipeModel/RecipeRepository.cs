using Domain.RecipeEntity;
using Infrastructure.Services;
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

        public async Task Delete(int recipeId)
        {
            await _dbContext.Recipe.RemoveRecipe(recipeId);
        }

        public async Task<Recipe> Get(int recipeId)
        {
            return await _dbContext.Recipe.GetRecipe(recipeId);
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

        public async Task RemoveFavorite(Favorite favorite)
        {
            await _dbContext.Favorite.RemoveFavorite(favorite);
        }

        public async Task RemoveLike(Like like)
        {
            await _dbContext.Like.RemoveLike(like);
        }

        public async Task SetFavorite(Favorite favorite)
        {
            await _dbContext.Favorite.AddAsync(favorite);
        }

        public async Task SetLike(Like like)
        {
            await _dbContext.Like.AddAsync(like);
        }

        public void Update(Recipe recipe)
        {
            _dbContext.Recipe.Update(recipe);
        }
    }
}
