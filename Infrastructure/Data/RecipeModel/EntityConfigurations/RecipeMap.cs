using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.RecipeModel.EntityConfigurations
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title);
            builder.Property(x => x.Description);
            builder.Property(x => x.CookingMinutes);
            builder.Property(x => x.NumberOfServings);
            builder.Property(x => x.AuthorId);
            builder.Property(x => x.Image);
            builder.HasMany(x => x.Step).WithOne(y => y.Recipe);
            builder.HasMany(x => x.Ingredient).WithOne(y => y.Recipe);
            builder.HasMany(x => x.Like).WithOne(y => y.Recipe);
            builder.HasMany(x => x.Favorite).WithOne(y => y.Recipe);
            builder.HasMany(x => x.Tag)
             .WithMany(y => y.Recipe)
             .UsingEntity<RecipeTag>(
                tag => tag
                    .HasOne(recipeTag => recipeTag.Tag)
                    .WithMany(tag => tag.RecipeTag)
                    .HasForeignKey(recipeTag => recipeTag.TagId),
                recipe => recipe
                    .HasOne(recipeTag => recipeTag.Recipe)
                    .WithMany(recipe => recipe.RecipeTag)
                    .HasForeignKey(recipeTag => recipeTag.RecipeId)
            );
        }
    }
}
