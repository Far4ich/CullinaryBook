using Domain.RecipeEntity;

namespace Api.Dto
{
    public record RecipeFullDto
    {
        public RecipeFullDto(
            int id,
            string title,
            string description,
            int cookingMinutes,
            int numberOfServings,
            string image,
            int authorId,
            List<Tag> tags,
            List<Like> likes,
            List<Favorite> favorites,
            List<Ingredient> ingredients,
            List<Step> steps)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            NumberOfServings = numberOfServings;
            Image = image;
            AuthorId = authorId;
            Tags = tags;
            Likes = likes;
            Favorites = favorites;
            Ingredients = ingredients;
            Steps = steps;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public int NumberOfServings { get; private set; }
        public string Image { get; private set; }
        public int AuthorId { get; private set; }
        public List<Tag> Tags { get; private set; }
        public List<Like> Likes { get; private set; }
        public List<Favorite> Favorites { get; private set; }
        public List<Step> Steps { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
    }
}
