using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.RecipeModel.EntityConfigurations
{
    public class RecipeTagMap : IEntityTypeConfiguration<RecipeTag>
    {
        public void Configure(EntityTypeBuilder<RecipeTag> builder)
        {
            builder.Property(x => x.RecipeId);
            builder.Property(x => x.TagId);
        }
    }
}
