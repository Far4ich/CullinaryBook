﻿using Domain.RecipeEntity;
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
            builder.Property(x => x.Name);
            builder.Property(x => x.Login);
            builder.Property(x => x.Password);
            builder.Property(x => x.AboutMe);
            builder.HasMany(x => x.Recipe).WithOne(y => y.Author);
            builder.HasMany(x => x.Like).WithOne(y => y.User);
            builder.HasMany(x => x.Favorite).WithOne(y => y.User);
        }
    }
}
