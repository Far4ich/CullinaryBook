using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Mappers
{
    public static class FavoriteMapper
    {
        public static FavoriteDto MapToFavoriteDto(this Favorite favorite)
        {
            return new FavoriteDto(favorite.UserId, favorite.RecipeId);
        }

        public static Favorite MapToFavorite(this FavoriteDto favorite)
        {
            return new Favorite(favorite.UserId, favorite.RecipeId);
        }
    }
}
