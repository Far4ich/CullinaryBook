namespace Domain.RecipeEntity
{
    public interface IUserRepository
    {
        User Get(int id);
        void Create(User user);
        void UpdateAboutMe(User user);
    }
}
