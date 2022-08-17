namespace Domain.RecipeEntity
{
    public class RecipeTag
    {
        public RecipeTag(int recipeId, Recipe recipe, int tagId, Tag tag)
        {
            RecipeId = recipeId;
            Recipe = recipe;
            TagId = tagId;
            Tag = tag;
        }

        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
        public int TagId { get; private set; }
        public Tag Tag { get; private set; }
    }
}
