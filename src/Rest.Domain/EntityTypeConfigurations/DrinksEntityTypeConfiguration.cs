using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class DrinksEntityTypeConfiguration : IEntityTypeConfiguration<Drinks>
    {
        public void Configure(EntityTypeBuilder<Drinks> builder)
        {
            builder.ToTable(nameof(Drinks));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdDrink");
            builder.Property(x => x.Price).HasColumnName(@"Price").HasColumnType("decimal");
        }
    }
}
