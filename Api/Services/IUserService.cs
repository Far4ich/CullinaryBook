using Api.Dto;

namespace Api.Services
{
    public interface IUserService
    {
        Task<List<FavoriteDto>> GetFavorites(int userId);
        Task<List<LikeDto>> GetLikes(int userId);
    }
}