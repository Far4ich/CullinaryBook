namespace Domain.RecipeEntity
{
    public class RecipeTag
    {
        public int Id { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
        public int TagId { get; private set; }
        public Tag Tag { get; private set; }
    }
}
