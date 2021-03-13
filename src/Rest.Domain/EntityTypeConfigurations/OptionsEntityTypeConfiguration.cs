using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public  class OptionsEntityTypeConfiguration : IEntityTypeConfiguration<Options>
    {
        public void Configure(EntityTypeBuilder<Options> builder)
        {
            builder.ToTable(nameof(Options));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdOption");

            builder.HasOne<Menus>(x => x.Menus).WithMany(m => m.Options).HasForeignKey(fk => fk.IdMenu);
        }
    }
}
