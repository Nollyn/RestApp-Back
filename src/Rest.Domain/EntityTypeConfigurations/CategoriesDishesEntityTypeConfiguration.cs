using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Entities;

namespace Rest.Domain.EntityTypeConfigurations
{
    class CategoriesDishesEntityTypeConfiguration : IEntityTypeConfiguration<CategoriesDishes>
    {
        public void Configure(EntityTypeBuilder<CategoriesDishes> builder)
        {
            builder.ToTable(nameof(CategoriesDishes));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdMenuCategory");

            builder.HasOne<Dishes>(x => x.Dishes).WithMany(m => m.CategoriesDishes).HasForeignKey(fk => fk.IdDish);
            builder.HasOne<Categories>(x => x.Categories).WithMany(m => m.CategoriesDishes).HasForeignKey(fk => fk.IdCategory);
        }
    }
}
