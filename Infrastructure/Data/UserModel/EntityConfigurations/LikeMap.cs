using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.UserModel.EntityConfigurations
{
    internal class LikeMap : IEntityTypeConfiguration<Like>
    {
        public void Configure(EntityTypeBuilder<Like> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.RecipeId).IsRequired();
            builder.HasOne(x => x.User)
                .WithMany(y => y.Likes)
                .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Recipe)
                .WithMany(y => y.Likes)
                .HasForeignKey(x => x.RecipeId);
        }
    }
}
