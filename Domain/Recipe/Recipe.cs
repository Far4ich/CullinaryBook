namespace Domain.RecipeEntity
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CookingMinutes { get; set; }
        public int NumberOfServings { get; set; }
        public string Image { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public List<Tag> Tags { get; set; } = new();
        public List<RecipeTag> RecipeTags { get; set; } = new();
        public List<Step> Steps { get; set; } = new();
        public List<Ingredient> Ingredients { get; set; } = new();
        public List<Like> Likes { get; set; } = new();
        public List<Favorite> Favorites { get; set; } = new();
    }
}
