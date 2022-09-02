namespace Api.Dto
{
    public record RecipeBestDto
    {
        public RecipeBestDto(
            int id,
            string title,
            string description,
            int cookingMinutes,
            string image,
            int countOfLikes)
        {
            Id = id;
            Title = title;
            Description = description;
            CookingMinutes = cookingMinutes;
            Image = image;
            CountOfLikes = countOfLikes;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int CookingMinutes { get; private set; }
        public string Image { get; private set; }
        public int CountOfLikes { get; private set; }
    }
}
