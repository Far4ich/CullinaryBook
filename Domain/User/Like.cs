namespace Domain.RecipeEntity
{
    public class Like
    {
        public Like(
            int userId,
            int recipeId)
        {
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
