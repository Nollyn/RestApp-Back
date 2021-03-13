using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class ExrasEntityTypeConfiguration : IEntityTypeConfiguration<Extras>
    {
        public void Configure(EntityTypeBuilder<Extras> builder)
        {
            builder.ToTable(nameof(Extras));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdExtra");

            builder.HasOne<Categories>(x => x.Categories).WithMany(m => m.Extras).HasForeignKey(fk => fk.IdCategory);
        }
    }
}
