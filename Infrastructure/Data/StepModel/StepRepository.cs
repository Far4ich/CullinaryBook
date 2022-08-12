using Domain.Step;

namespace Infrastructure.Data.StepModel
{
    public class StepRepository : IStepRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public StepRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Step step)
        {
            throw new NotImplementedException();
        }

        public void Delete(Step step)
        {
            throw new NotImplementedException();
        }

        public List<Step> GetStepsByRecipeId(int recipeId)
        {
            throw new NotImplementedException();
        }

        public void Update(Step step)
        {
            throw new NotImplementedException();
        }
    }
}
