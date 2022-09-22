using Domain.RecipeEntity;
using Domain.UoW;
using Api.Dto;
using Api.Services.Mappers;

namespace Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
        {
            _userRepository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<LikeDto>> GetLikes(int userId)
        {
            List<Like> likes = await _userRepository.GetLikes(userId);

            return likes.ConvertAll(l => l.MapToLikeDto());
        }

        public async Task<List<FavoriteDto>> GetFavorites(int userId)
        {
            List<Favorite> favorites = await _userRepository.GetFavorites(userId);

            return favorites.ConvertAll(f => f.MapToFavoriteDto());
        }
    }
}
