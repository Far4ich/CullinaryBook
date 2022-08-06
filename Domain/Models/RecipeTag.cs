namespace Domain.Models
{
    public class RecipeTag
    {
        public RecipeTag(int recipeId, int tagId)
        {
            RecipeId = recipeId;
            TagId = tagId;
        }

        public int RecipeId { get; private set; }
        public int TagId { get; private set; }
    }
}
