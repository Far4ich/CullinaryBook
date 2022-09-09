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
        Task Delete(int recipeId);
        Task SetLike(Like like);
        Task RemoveLike(Like like);
        Task SetFavorite(Favorite favorite);
        Task RemoveFavorite(Favorite favorite);
    }
}
