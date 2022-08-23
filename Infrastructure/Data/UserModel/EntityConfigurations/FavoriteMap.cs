using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.UserModel.EntityConfigurations
{
    public class FavoriteMap : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.RecipeId).IsRequired();
            builder.HasOne(x => x.User).WithMany(y => y.Favorites);
            builder.HasOne(x => x.Recipe).WithMany(y => y.Favorites);
        }
    }
}
