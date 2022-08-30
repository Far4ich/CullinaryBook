using Infrastructure.Data;
using Infrastructure.Data.RecipeModel;
using Infrastructure.Data.UserModel;
using Domain.UoW;

namespace Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly CullinaryBookContext _ctx;
    private RecipeRepository recipeRepository;
    private UserRepository userRepository;

    public UnitOfWork(CullinaryBookContext ctx)
    {
        _ctx = ctx;
    }
    public RecipeRepository Recipe
    {
        get
        {
            if (recipeRepository == null)
                recipeRepository = new RecipeRepository(_ctx);
            return recipeRepository;
        }
    }

    public UserRepository User
    {
        get
        {
            if (userRepository == null)
                userRepository = new UserRepository(_ctx);
            return userRepository;
        }
    }

    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        await _ctx.SaveChangesAsync(cancellationToken);

        return true;
    }
}
