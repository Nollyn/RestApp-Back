﻿using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class RestaurantsMenusEntityTypeConfiguration : IEntityTypeConfiguration<RestaurantsMenus>
    {
        public void Configure(EntityTypeBuilder<RestaurantsMenus> builder)
        {
            builder.ToTable(nameof(RestaurantsMenus));
            builder.HasKey(x => new { x.IdMenu, x.IdRestaurant });

            builder.HasOne<Restaurants>(x => x.Restaurants).WithMany(m => m.RestaurantsMenus).HasForeignKey(fk => fk.IdRestaurant);
            builder.HasOne<Menus>(x => x.Menus).WithMany(m => m.RestaurantsMenus).HasForeignKey(fk => fk.IdMenu);

        }
    }
}
