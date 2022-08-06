using Domain.Models;

namespace Domain.RepositoryInterfaces
{
    public interface IUserRepository
    {
        User Get(int id);
        void Create(User user);
        void Update(User user);
    }
}
