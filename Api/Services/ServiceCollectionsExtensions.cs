using Domain.RecipeEntity;
using Infrastructure.Data.RecipeModel;
using Api.Services.Builders;
using Infrastructure.Data.UserModel;

namespace Api.Services
{
    public static class ServiceCollectionsExtensions
    {
        public static void AddApiServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRecipeRepository, RecipeRepository>();
            serviceCollection.AddScoped<IRecipeService, RecipeService>();
            serviceCollection.AddScoped<IRecipeBuilder, RecipeBuilder>();
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IUserService, UserService>();
        }
    }
}
