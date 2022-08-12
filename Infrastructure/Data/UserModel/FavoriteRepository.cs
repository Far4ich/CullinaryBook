using Domain.User;

namespace Infrastructure.Data.UserModel
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public FavoriteRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Favorite favorite)
        {
            throw new NotImplementedException();
        }

        public void Delete(Favorite favorite)
        {
            throw new NotImplementedException();
        }

        public List<Favorite> GetFavoritesByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
