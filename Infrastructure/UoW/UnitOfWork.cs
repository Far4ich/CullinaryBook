using Infrastructure.Data;

namespace Infrastructure.UoW;

public class UnitOfWork : IUnitOfWork
{
    private readonly CullinaryBookContext _ctx;

    public UnitOfWork(CullinaryBookContext ctx)
    {
        _ctx = ctx;
    }

    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        return await _ctx.SaveEntitiesAsync(cancellationToken);
    }
}
