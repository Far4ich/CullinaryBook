using Domain.RecipeEntity;
using Infrastructure.Data.RecipeModel;
using Api.Services.Builders;

namespace Api.Services
{
    public static class ServiceCollectionsExtensions
    {
        public static void AddApiServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRecipeRepository, RecipeRepository>();
            serviceCollection.AddScoped<IRecipeService, RecipeService>();
            serviceCollection.AddScoped<IRecipeBuilder, RecipeBuilder>();
        }
    }
}
