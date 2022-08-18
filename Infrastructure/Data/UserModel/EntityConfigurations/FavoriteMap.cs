﻿using Domain.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.UserModel.EntityConfigurations
{
    public class FavoriteMap : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.Property(x => x.UserId);
            builder.Property(x => x.RecipeId);
        }
    }
}