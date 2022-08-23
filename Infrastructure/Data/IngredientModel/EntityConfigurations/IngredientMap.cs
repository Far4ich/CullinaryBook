using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.IngredientModel.EntityConfigurations
{
    public class IngredientMap : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Products).HasMaxLength(511).IsRequired();
            builder.Property(x => x.Order).IsRequired();
            builder.Property(x => x.RecipeId).IsRequired();
            builder.HasOne(x => x.Recipe)
                .WithMany(y => y.Ingredients)
                .HasForeignKey(x => x.RecipeId);
        }
    }
}
