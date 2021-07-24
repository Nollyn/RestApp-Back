using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Entities;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class MenuDishesEntityTypeConfiguration : IEntityTypeConfiguration<MenuDishes>
    {
        public void Configure(EntityTypeBuilder<MenuDishes> builder)
        {
            builder.ToTable(nameof(MenuDishes));
            builder.HasKey(x => new { x.IdCategory, x.IdDish, x.IdMenu });

            builder.HasOne<Menus>(x => x.Menus).WithMany(m => m.MenuDishes).HasForeignKey(fk => fk.IdMenu);
            builder.HasOne<Dishes>(x => x.Dishes).WithMany(m => m.MenuDishes).HasForeignKey(fk => fk.IdDish);
            builder.HasOne<Categories>(x => x.Categories).WithMany(m => m.MenuDishes).HasForeignKey(fk => fk.IdCategory);
        }
    }
}
