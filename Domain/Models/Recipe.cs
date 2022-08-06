namespace Domain.Models
{
    public class Recipe
    {
        public Recipe(int id, string title, string description, int cookingMinutes, int numberOfServings, int authorId, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            NumberOfServings = numberOfServings;
            AuthorId = authorId;
            Image = image;
        }

        public int Id { get;private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public int NumberOfServings { get; private set; }
        public int AuthorId { get; private set; }
        public string Image { get; private set; }
    }
}
