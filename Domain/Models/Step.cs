namespace Domain.Models
{
    public class Step
    {
        public Step(int id, string title, string description, int recipeId)
        {
            Id = id;
            Title = title;
            Description = description;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int RecipeId { get; private set; }
    }
}
