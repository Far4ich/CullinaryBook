using Domain.RecipeEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.StepModel.EntityConfigurations
{
    public class StepMap : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Order).IsRequired();
            builder.Property(x => x.RecipeId).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(511).IsRequired();
            builder.HasOne(x => x.Recipe).WithMany(y => y.Steps);
        }
    }
}
