using Domain.Models;

namespace Domain.RepositoryInterfaces
{
    public interface IFavoriteRepository
    {
        List<Favorite> GetFavoritesByUserId(int userId);
        void Create(Favorite favorite);
        void Delete(Favorite favorite);
    }
}
