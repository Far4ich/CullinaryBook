using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.UserModel.EntityConfigurations
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Login).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(100).IsRequired();
            builder.Property(x => x.AboutMe).HasMaxLength(255);
            builder.HasMany(x => x.Recipes)
                .WithOne(y => y.Author)
                .HasForeignKey(y => y.AuthorId);
        }
    }
}
