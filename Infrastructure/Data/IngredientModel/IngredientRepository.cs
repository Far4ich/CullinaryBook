using Domain.Ingredient;

namespace Infrastructure.Data.IngredientModel
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly CullinaryBookContext _dbContext;

        public IngredientRepository(CullinaryBookContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public Ingredient Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
