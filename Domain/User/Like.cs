namespace Domain.User
{
    public class Like
    {
        public Like(int userId, User user, int recipeId, Recipe.Recipe recipe)
        {
            UserId = userId;
            RecipeId = recipeId;
            User = user;
            Recipe = recipe;
        }

        public int UserId { get; private set; }
        public User User { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe.Recipe Recipe { get; private set; }
    }
}
