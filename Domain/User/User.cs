using EasyAbp.Abp.EntityUi.Entities;

namespace Domain.RecipeEntity
{
    public class User
    {
        public User(int id, string name, string login, string password, string aboutMe)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
            AboutMe = aboutMe;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string AboutMe { get; private set; }
        public List<Like> Likes { get; set; } = new();
        public List<Favorite> Favorites { get; set; } = new();
        public List<Recipe> Recipes { get; set; } = new();
    }
}
