using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Entities;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class OrdersDrinksEntityTypeConfiguration : IEntityTypeConfiguration<OrdersDrinks>
    {
        public void Configure(EntityTypeBuilder<OrdersDrinks> builder)
        {
            builder.ToTable(nameof(OrdersDrinks));
            builder.HasKey(x => new { x.IdOrder, x.IdDrink });

            builder.HasOne<Drinks>(x => x.Drinks).WithMany(m => m.OrdersDrinks).HasForeignKey(fk => fk.IdDrink);
            builder.HasOne<Orders>(x => x.Orders).WithMany(m => m.OrdersDrinks).HasForeignKey(fk => fk.IdOrder);
        }
    }
}
