using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.StepModel.EntityConfigurations
{
    public class StepMap : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Order);
            builder.Property(x => x.RecipeId);
            builder.Property(x => x.Description);
        }
    }
}
