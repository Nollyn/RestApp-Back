using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class RestaurantsEntityTypeConfiguration : IEntityTypeConfiguration<Restaurants>
    {
        public void Configure(EntityTypeBuilder<Restaurants> builder)
        {
            builder.ToTable(nameof(Restaurants));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdRestaurant");
        }
    }
}
