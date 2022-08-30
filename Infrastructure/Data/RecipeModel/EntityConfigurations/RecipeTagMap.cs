using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.RecipeModel.EntityConfigurations
{
    public class RecipeTagMap : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.RecipeId).IsRequired();
            builder.Property(x => x.TagId).IsRequired();
            builder.HasOne(x => x.Tag)
                .WithMany(y => y.RecipeTags)
                .HasForeignKey(x => x.TagId);
            builder.HasOne(x => x.Recipe)
                .WithMany(y => y.RecipeTags)
                .HasForeignKey(x => x.RecipeId);
        }
    }
}
