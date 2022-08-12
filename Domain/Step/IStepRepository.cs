namespace Domain.Step
{
    public interface IStepRepository
    {
        List<Step> GetStepsByRecipeId(int recipeId);
        void Create(Step step);
        void Update(Step step);
        void Delete(Step step);
    }
}
