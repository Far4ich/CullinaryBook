using EasyAbp.Abp.EntityUi.Entities;

namespace Domain.RecipeEntity
{
    public class Favorite
    {
        public Favorite(int id,int userId, int recipeId)
        {
            Id = id;
            UserId = userId;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
    }
}
