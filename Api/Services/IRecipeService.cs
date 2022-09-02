using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Services
{
    public interface IRecipeService
    {
        List<RecipeListDto> GetAll();
        RecipeFullDto Get(int recipeId);
        List<RecipeListDto> GetByTag(int tagId);
        RecipeBestDto GetBestRecipe();
        void Create(RecipeFullDto recipe);
        void Update(RecipeFullDto recipe);
        void Delete(int recipeId);
        void SetLike(int recipeId, int userId);
        void RemoveLike(int recipeId, int userId);
        void SetFavorite(int recipeId, int userId);
        void RemoveFavorite(int recipeId, int userId);
    }
}
