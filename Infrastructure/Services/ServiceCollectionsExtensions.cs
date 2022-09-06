using Domain.UoW;
using Infrastructure.UoW;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services
{
    public static class ServiceCollectionsExtensions
    {
        public static void AddEntityFramework(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<CullinaryBookContext>(option =>
                    option.UseSqlServer(connectionString));
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
