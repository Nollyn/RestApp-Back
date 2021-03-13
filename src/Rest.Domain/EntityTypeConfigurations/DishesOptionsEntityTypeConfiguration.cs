using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class DishesOptionsEntityTypeConfiguration : IEntityTypeConfiguration<DishesOptions>
    {
        public void Configure(EntityTypeBuilder<DishesOptions> builder)
        {
            builder.ToTable(nameof(DishesOptions));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdDishOption");

            builder.HasOne<Dishes>(x => x.Dishes).WithMany(m => m.DishesOptions).HasForeignKey(fk => fk.IdDish);
            builder.HasOne<Options>(x => x.Options).WithMany(m => m.DishesOptions).HasForeignKey(fk => fk.IdOption);
        }
    }
}
