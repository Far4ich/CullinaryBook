using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.UserModel.EntityConfigurations
{
    internal class LikeMap : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {        
            builder.Property(x => x.UserId);
            builder.Property(x => x.RecipeId);
            builder.HasOne(x => x.User).WithMany(y => y.Likes);
            builder.HasOne(x => x.Recipe).WithMany(y => y.Likes);
        }
    }
}
