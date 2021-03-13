using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class TablesEntityTypeConfiguration : IEntityTypeConfiguration<Tables>
    {
        public void Configure(EntityTypeBuilder<Tables> builder)
        {
            builder.ToTable(nameof(Tables));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdTable");

            builder.HasOne<Restaurants>(x => x.Restaurants).WithMany(m => m.Tables).HasForeignKey(fk => fk.IdRestaurant);
        }
    }
}
