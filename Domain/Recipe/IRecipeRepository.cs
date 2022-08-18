using Domain.RecipeDto;

namespace Domain.RecipeEntity
{
    public interface IRecipeRepository
    {
        List<Recipe> GetAll();
        Recipe Get(int id);
        List<RecipeTopDto> GetByTag(int id);
        RecipeTopDto GetBestRecipe();
        void Create(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(int id);
        void SetTags(List<Tag> tags, int id);//планирую там же проверять существует ли тэг и создавать если его нет
        void SetLike(int recipeId, int userId);
        void RemoveLike(int recipeId, int userId);
        void SetFavorite(int recipeId, int userId);
        void RemoveFavorite(int recipeId, int userId);
    }
}
