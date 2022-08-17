namespace Domain.RecipeEntity
{
    public class Recipe
    {
        public Recipe(int id, string title, string description, int cookingMinutes, int numberOfServings, string image, int authorId, User author)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            NumberOfServings = numberOfServings;
            AuthorId = authorId;
            Author = author;
            Image = image;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public int NumberOfServings { get; private set; }
        public string Image { get; private set; }

        public int AuthorId { get; private set; }
        public User Author { get; private set; }

        public List<RecipeTag> RecipeTag { get; set; } = new();
        public List<Step> Stap { get; set; } = new();
        public List<Ingredient> Ingredient { get; set; } = new();
        public List<Like> Like { get; set; } = new();
        public List<Favorite> Favorite { get; set; } = new();
    }
}
