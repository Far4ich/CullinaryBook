using Domain.Models;

namespace Domain.User
{
    public interface IUserRepository
    {
        User Get(int id);
        void Create(User user);
        void Update(User user);
    }
}
