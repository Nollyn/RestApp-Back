using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class MenusEntityTypeConfiguration : IEntityTypeConfiguration<Menus>
    {
        public void Configure(EntityTypeBuilder<Menus> builder)
        {
            builder.ToTable(nameof(Menus));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdMenu");
        }
    }
}
