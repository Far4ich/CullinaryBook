using Domain.Recipe;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.RecipeModel.EntityConfigurations
{
    public class RecipeMap : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Title);
            builder.Property(x => x.Description);
            builder.Property(x => x.CookingMinutes);
            builder.Property(x => x.NumberOfServings);
            builder.Property(x => x.AuthorId);
            builder.Property(x => x.Image);
        }
    }
}
