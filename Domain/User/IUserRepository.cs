namespace Domain.RecipeEntity
{
    public interface IUserRepository
    {
        User Get(int id);
        Task<List<Like>> GetLikes(int userId);
        Task<List<Favorite>> GetFavorites(int userId);
        void Create(User user);
        void Update(User user);
    }
}
