namespace Domain.User
{
    public class Like
    {
        public Like(int userId, int recipeId)
        {
            UserId = userId;
            RecipeId = recipeId;
        }

        public int UserId { get; private set; }
        public int RecipeId { get; private set; }
    }
}
