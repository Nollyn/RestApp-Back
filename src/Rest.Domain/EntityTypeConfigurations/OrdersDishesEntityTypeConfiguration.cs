using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Entities;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class OrdersDishesEntityTypeConfiguration : IEntityTypeConfiguration<OrdersDiches>
    {
        public void Configure(EntityTypeBuilder<OrdersDiches> builder)
        {
            builder.ToTable(nameof(OrdersDiches));
            builder.HasKey(x => new { x.IdOrder, x.IdDish });

            builder.HasOne<Dishes>(x => x.Dishes).WithMany(m => m.OrdersDiches).HasForeignKey(fk => fk.IdDish);
            builder.HasOne<Orders>(x => x.Orders).WithMany(m => m.OrdersDiches).HasForeignKey(fk => fk.IdOrder);
        }
    }
}
