namespace Domain.RecipeEntity
{
    public interface IRecipeRepository
    {
        List<Recipe> GetAll();
        Recipe Get(int recipeId);
        List<Recipe> GetByTag(int tagId);
        Recipe GetBestRecipe();
        void Create(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(int recipeId);
        void SetLike(int recipeId, int userId);
        void RemoveLike(int recipeId, int userId);
        void SetFavorite(int recipeId, int userId);
        void RemoveFavorite(int recipeId, int userId);
    }
}
