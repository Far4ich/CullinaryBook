namespace Domain.RecipeEntity
{
    public class Ingredient
    {
        public Ingredient(
            int id, 
            string title,
            int order, 
            string products,
            int recipeId)
        {
            Id = id;
            Title = title;
	        Order = order;
            Products = products;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public int Order { get; private set; }
        public string Products { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
    }
}
