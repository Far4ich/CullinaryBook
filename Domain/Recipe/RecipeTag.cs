namespace Domain.RecipeEntity
{
    public class RecipeTag
    {
        public RecipeTag(
            int id,
            int recipeId, 
            int tagId)
        {
            Id = id;
            RecipeId = recipeId;
            TagId = tagId;
        }
        public int Id { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
        public int TagId { get; private set; }
        public Tag Tag { get; private set; }
    }
}
