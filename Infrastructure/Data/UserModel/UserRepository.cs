﻿using Domain.RecipeEntity;

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

        public List<Favorite> GetFavorites(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Like> GetLikes(int userId)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
