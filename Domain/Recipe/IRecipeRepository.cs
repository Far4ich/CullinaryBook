namespace Domain.RecipeEntity
{
    public interface IRecipeRepository
    {
        List<Recipe> GetAll();
        Recipe Get(int id);
        void Create(Recipe recipe);
        void Update(Recipe recipe);
        void Delete(int id);
    }
}
