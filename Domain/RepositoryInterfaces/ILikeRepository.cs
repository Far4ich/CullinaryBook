using Domain.Models;

namespace Domain.RepositoryInterfaces
{
    public interface ILikeRepository
    {
        List<Like> GetLikesByUserId(int userId);
        void Create(Like like);
        void Delete(Like like);
    }
}
