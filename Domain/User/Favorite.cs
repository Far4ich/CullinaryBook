namespace Domain.RecipeEntity
{
    public class Favorite
    {
        public Favorite(int userId, User user, int recipeId, Recipe recipe)
        {
            UserId = userId;
            RecipeId = recipeId;
            User = user;
            Recipe = recipe;
        }

        public int UserId { get; private set; }
        public User User { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
    }
}
