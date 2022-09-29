using Domain.RecipeEntity;
using Api.Dto;

namespace Api.Services
{
    public interface IRecipeService
    {
        Task<List<RecipeDto>> GetAll();
        Task<RecipeFullDto> Get(int recipeId);
        Task<List<RecipeDto>> GetByTag(int tagId);
        Task<RecipeBestDto> GetBestRecipe();
        Task Save(RecipeEditDto recipe);
        Task Delete(int recipeId);
        Task AddLike(LikeDto likeDto);
        Task RemoveLike(LikeDto likeDto);
        Task AddFavorite(FavoriteDto favoriteDto);
        Task RemoveFavorite(FavoriteDto favoriteDto);
    }
}
