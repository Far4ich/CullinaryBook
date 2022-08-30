namespace Domain.RecipeEntity
{
    public class Step
    {
        public Step(
            int id,
            int orderNumber,
            string description,
            int recipeId)
        {
            Id = id;
            OrderNumber = orderNumber;
            Description = description;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public int OrderNumber { get; private set; }
        public string Description { get; private set; }

        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
    }
}
