using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Services
{
    public interface IRecipeService
    {
        Task<List<RecipeShortDto>> GetAll();
        Task<RecipeDto> Get(int recipeId);
        Task<List<RecipeShortDto>> GetByTag(int tagId);
        Task<RecipeBestDto> GetBestRecipe();
        Task Create(RecipeDto recipe);
        Task Update(RecipeDto recipe);
        Task Delete(int recipeId);
        Task SetLike(int recipeId, int userId);
        Task RemoveLike(int recipeId, int userId);
        Task SetFavorite(int recipeId, int userId);
        Task RemoveFavorite(int recipeId, int userId);
    }
}
