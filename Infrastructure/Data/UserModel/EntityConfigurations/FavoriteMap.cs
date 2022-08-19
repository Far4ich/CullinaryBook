using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.UserModel.EntityConfigurations
{
    public class FavoriteMap : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.Property(x => x.UserId);
            builder.Property(x => x.RecipeId);
            builder.HasOne(x => x.User).WithMany(y => y.Favorite);
            builder.HasOne(x => x.Recipe).WithMany(y => y.Favorite);
        }
    }
}
