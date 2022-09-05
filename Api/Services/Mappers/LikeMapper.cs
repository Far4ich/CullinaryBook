using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Mappers
{
    public static class LikeMapper
    {
        public static LikeDto MapToLikeDto(this Like like)
        {
            return new LikeDto(
                like.Id,
                like.UserId,
                like.RecipeId);
        }

        public static Like MapToLike(this LikeDto like)
        {
            return new Like(
                like.UserId,
                like.RecipeId);
        }
    }
}

