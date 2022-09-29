using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.UserModel
{
    public class UserRepository : IUserRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public UserRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Favorite>> GetFavorites(int userId)
        {
            return await _dbContext.Favorite
                .Where(f => f.UserId == userId)
                .ToListAsync();
        }

        public async Task<List<Like>> GetLikes(int userId)
        {
            return await _dbContext.Like
                .Where(l => l.UserId == userId)
                .ToListAsync();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
