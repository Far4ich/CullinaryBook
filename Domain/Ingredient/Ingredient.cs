namespace Domain.RecipeEntity
{
    public class Ingredient
    {
        public Ingredient(
            string title,
            int orderNumber, 
            string products,
            int recipeId)
        {
            Title = title;
	        OrderNumber = orderNumber;
            Products = products;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public int OrderNumber { get; private set; }
        public string Products { get; private set; }
        public int RecipeId { get; private set; }
        public Recipe Recipe { get; private set; }
    }
}
