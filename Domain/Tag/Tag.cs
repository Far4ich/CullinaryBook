namespace Domain.RecipeEntity
{
    public class Tag
    {
        public Tag(string title)
        {
            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

        public List<RecipeTag> RecipeTags { get; set; } = new();
        public List<Recipe> Recipes { get; set; } = new();
    }
}
