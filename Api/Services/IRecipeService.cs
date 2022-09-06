using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Services
{
    public interface IRecipeService
    {
        Task<List<RecipeDto>> GetAll();
        Task<RecipeEditDto> Get(int recipeId);
        Task<List<RecipeDto>> GetByTag(int tagId);
        Task<RecipeBestDto> GetBestRecipe();
        Task Create(RecipeEditDto recipe);
        Task Update(RecipeEditDto recipe);
        Task Delete(int recipeId);
        Task SetLike(int recipeId, int userId);
        Task RemoveLike(int recipeId, int userId);
        Task SetFavorite(int recipeId, int userId);
        Task RemoveFavorite(int recipeId, int userId);
    }
}
