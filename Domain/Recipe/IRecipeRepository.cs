namespace Domain.RecipeEntity
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> GetRecipes();
        Task<Recipe> Get(int recipeId);
        List<Recipe> GetByTag(int tagId);
        Recipe GetBestRecipe();
        Task<List<Tag>> GetTags();
        Task Create(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(Recipe recipe);
        Task<Like> GetLike(int recipeId, int userId);
        Task SetLike(Like like);
        void RemoveLike(Like like);
        Task<Favorite> GetFavorite(int recipeId, int userId);
        Task SetFavorite(Favorite favorite);
        void RemoveFavorite(Favorite favorite);
    }
}
