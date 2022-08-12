namespace Domain.User
{
    public class Favorite
    {
        public Favorite(int userId, int recipeId)
        {
            UserId = userId;
            RecipeId = recipeId;
        }

        public int UserId { get; private set; }
        public int RecipeId { get; private set; }
    }
}
