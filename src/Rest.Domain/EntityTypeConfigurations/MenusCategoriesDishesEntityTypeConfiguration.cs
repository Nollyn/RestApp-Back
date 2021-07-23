using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Entities;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class MenusCategoriesDishesEntityTypeConfiguration : IEntityTypeConfiguration<MenusCategoriesDishes>
    {
        public void Configure(EntityTypeBuilder<MenusCategoriesDishes> builder)
        {
            builder.ToTable(nameof(MenusCategoriesDishes));
            builder.HasKey(x => new { x.IdMenuCategory, x.IdDish });

            builder.HasOne<MenusCategories>(x => x.MenusCategories).WithMany(m => m.MenusCategoriesDishes).HasForeignKey(fk => fk.IdMenuCategory);
            builder.HasOne<Dishes>(x => x.Dishes).WithMany(m => m.MenusCategoriesDishes).HasForeignKey(fk => fk.IdDish);

        }
    }
}
