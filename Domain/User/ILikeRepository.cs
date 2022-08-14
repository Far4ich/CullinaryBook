namespace Domain.User
{
    public interface ILikeRepository
    {
        List<Like> GetLikesByUserId(int userId);
    }
}
