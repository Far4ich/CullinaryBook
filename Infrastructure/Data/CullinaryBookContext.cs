using Domain.User;
using Domain.Ingredient;
using Domain.Tag;
using Domain.Recipe;
using Domain.Step;
using Infrastructure.UoW;
using Infrastructure.Data.UserModel.EntityConfigurations;
using Infrastructure.Data.IngredientModel.EntityConfigurations;
using Infrastructure.Data.TagModel.EntityConfigurations;
using Infrastructure.Data.RecipeModel.EntityConfigurations;
using Infrastructure.Data.StepModel.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class CullinaryBookContext : DbContext, IUnitOfWork
    {
        public CullinaryBookContext(DbContextOptions<CullinaryBookContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Favorite> Favorite { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<RecipeTag> RecipeId { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Step> Step { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new LikeMap());
            builder.ApplyConfiguration(new FavoriteMap());
            builder.ApplyConfiguration(new RecipeMap());
            builder.ApplyConfiguration(new RecipeTagMap());
            builder.ApplyConfiguration(new TagMap());
            builder.ApplyConfiguration(new StepMap());
            builder.ApplyConfiguration(new IngredientMap());
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}