namespace Domain.RecipeEntity
{
    public interface IUserRepository
    {
        User Get(int id);
        List<Like> GetLikes(int userId);
        List<Favorite> GetFavorites(int userId);
        void Create(User user);
        void Update(User user);
    }
}
