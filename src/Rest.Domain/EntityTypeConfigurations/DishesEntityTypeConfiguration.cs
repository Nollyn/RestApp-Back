﻿using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class DishesEntityTypeConfiguration : IEntityTypeConfiguration<Dishes>
    {
        public void Configure(EntityTypeBuilder<Dishes> builder)
        {
            builder.ToTable(nameof(Dishes));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdDish");
            builder.Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal");

            builder.HasOne<Categories>(x => x.Categories).WithMany(m => m.Dishes).HasForeignKey(fk => fk.IdCategory);
        }
    }
}
