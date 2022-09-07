namespace Domain.RecipeEntity
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> GetRecipeList();
        Task<Recipe> Get(int recipeId);
        List<Recipe> GetByTag(int tagId);
        Recipe GetBestRecipe();
        Task<List<Tag>> GetAllTags();
        Task Create(Recipe recipe);
        void Update(Recipe recipe);
        Task Delete(int recipeId);
        Task SetLike(int recipeId, int userId);
        Task RemoveLike(int recipeId, int userId);
        Task SetFavorite(int recipeId, int userId);
        Task RemoveFavorite(int recipeId, int userId);
    }
}
