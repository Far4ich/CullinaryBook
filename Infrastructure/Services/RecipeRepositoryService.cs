using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public static class RecipeRepositoryService
    {
        public static async Task<Recipe> GetRecipe(this DbSet<Recipe> recipeDb, int recipeId)
        {
            Recipe recipe = await recipeDb
                .Where(recipe => recipe.Id == recipeId)
                .Include(recipe => recipe.Tags)
                .Include(recipe => recipe.RecipeTags)
                .Include(recipe => recipe.Ingredients)
                .Include(recipe => recipe.Steps)
                .FirstOrDefaultAsync();

            if (recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found, #Id - {recipeId}");
            }

            return recipe;
        }
        public static async Task RemoveRecipe(this DbSet<Recipe> recipeDb, int recipeId)
        {
            recipeDb.Remove(await GetRecipe(recipeDb, recipeId));
        }

        public static async Task RemoveFavorite(this DbSet<Favorite> favoriteDb, Favorite favorite)
        {
            var favoriteForRemove = await favoriteDb
                .SingleOrDefaultAsync(x => x.RecipeId == favorite.RecipeId && x.UserId == favorite.UserId);

            if (favoriteForRemove == null)
            {
                throw new Exception($"{nameof(Favorite)} not found");
            }

            favoriteDb.Remove(favoriteForRemove);
        }
        public static async Task RemoveLike(this DbSet<Like> likeDb, Like like)
        {
            var likeForRemove = await likeDb
                .SingleOrDefaultAsync(x => x.RecipeId == like.RecipeId && x.UserId == like.UserId);

            if (likeForRemove == null)
            {
                throw new Exception($"{nameof(Like)} not found");
            }

            likeDb.Remove(likeForRemove);
        }
    }
}
