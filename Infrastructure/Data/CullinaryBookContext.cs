using Domain.RecipeEntity;
using Infrastructure.UoW;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
        public DbSet<RecipeTag> RecipeTag { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Step> Step { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}