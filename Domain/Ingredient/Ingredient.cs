namespace Domain.Ingredient
{
    public class Ingredient
    {
        public Ingredient(int id, string title, string products, int recipeId)
        {
            Id = id;
            Title = title;
            Products = products;
            RecipeId = recipeId;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Products { get; private set; }
        public int RecipeId { get; private set; }
    }
}
