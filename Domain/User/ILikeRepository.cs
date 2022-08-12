namespace Domain.User
{
    public interface ILikeRepository
    {
        List<Like> GetLikesByUserId(int userId);
        void Create(Like like);
        void Delete(Like like);
    }
}
