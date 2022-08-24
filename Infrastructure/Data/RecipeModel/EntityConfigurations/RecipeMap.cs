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
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(511).IsRequired();
            builder.Property(x => x.CookingMinutes).IsRequired();
            builder.Property(x => x.NumberOfServings).IsRequired();
            builder.Property(x => x.AuthorId).IsRequired();
            builder.Property(x => x.Image).HasMaxLength(100);
            builder.HasOne(x => x.Author)
                .WithMany(y => y.Recipes)
                .HasForeignKey(x => x.AuthorId);
            builder.HasMany(x => x.Tags)
             .WithMany(y => y.Recipes)
             .UsingEntity<RecipeTag>(
                tag => tag
                    .HasOne(recipeTag => recipeTag.Tag)
                    .WithMany(tag => tag.RecipeTags)
                    .HasForeignKey(recipeTag => recipeTag.TagId),
                recipe => recipe
                    .HasOne(recipeTag => recipeTag.Recipe)
                    .WithMany(recipe => recipe.RecipeTags)
                    .HasForeignKey(recipeTag => recipeTag.RecipeId)
            );
        }
    }
}
