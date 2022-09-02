using Domain.RecipeEntity;

namespace Api.Dto
{
    public record RecipeListDto
    {
        public RecipeListDto(
            int id,
            string title,
            string description,
            int cookingMinutes,
            int numberOfServings,
            string image,
            List<Tag> tags,
            List<Like> likes,
            List<Favorite> favorites)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            NumberOfServings = numberOfServings;
            Image = image;
            Tags = tags;
            Likes = likes;
            Favorites = favorites;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public int NumberOfServings { get; private set; }
        public string Image { get; private set; }
        public List<Tag> Tags { get; private set; }
        public List<Like> Likes { get; private set; }
        public List<Favorite> Favorites { get; private set; }
    }
}
