namespace Domain.Step
{
    public interface IStepRepository
    {
        List<Step> GetStepsByRecipeId(int recipeId);
    }
}
