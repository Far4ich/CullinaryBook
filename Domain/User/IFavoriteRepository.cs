namespace Domain.User
{
    public interface IFavoriteRepository
    {
        List<Favorite> GetFavoritesByUserId(int userId);
    }
}
