namespace Api.Dto
{
    public class RecipeTopDto
    {
        public RecipeTopDto(
            int id,
            string title,
            string description,
            int cookingMinutes,
            int numberOfServings,
            string image,
            int authorId)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            NumberOfServings = numberOfServings;
            AuthorId = authorId;
            Image = image;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public int NumberOfServings { get; private set; }
        public string Image { get; private set; }
        public int AuthorId { get; private set; }
    }
}
