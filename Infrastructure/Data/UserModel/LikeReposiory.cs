using Domain.User;

namespace Infrastructure.Data.UserModel
{
    public class LikeReposiory : ILikeRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public LikeReposiory(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Like like)
        {
            throw new NotImplementedException();
        }

        public void Delete(Like like)
        {
            throw new NotImplementedException();
        }

        public List<Like> GetLikesByUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
