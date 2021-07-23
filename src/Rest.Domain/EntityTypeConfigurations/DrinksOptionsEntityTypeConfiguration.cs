using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class DrinksOptionsEntityTypeConfiguration : IEntityTypeConfiguration<DrinksOptions>
    {
        public void Configure(EntityTypeBuilder<DrinksOptions> builder)
        {
            builder.ToTable(nameof(DrinksOptions));
            builder.HasKey(x => new { x.IdOption, x.IdDrink });

            builder.HasOne<Options>(x => x.Options).WithMany(m => m.DrinksOptions).HasForeignKey(fk => fk.IdOption);
            builder.HasOne<Drinks>(x => x.Drinks).WithMany(m => m.DrinksOptions).HasForeignKey(fk => fk.IdDrink);
        }
    }
}
