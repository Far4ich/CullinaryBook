namespace Domain.User
{
    public interface IFavoriteRepository
    {
        List<Favorite> GetFavoritesByUserId(int userId);
        void Create(Favorite favorite);
        void Delete(Favorite favorite);
    }
}
