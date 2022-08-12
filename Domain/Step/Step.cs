namespace Domain.Step
{
    public class Step
    {
        public Step(int id, string order, string description, int recipeId)
        {
            Id = id;
            Order = order;
            Description = description;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public string Order { get; private set; }
        public string Description { get; private set; }
        public int RecipeId { get; private set; }
    }
}
