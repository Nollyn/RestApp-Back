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
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Menus).WithMany(m => m.MenuDishes).HasForeignKey(fk => fk.IdMenu);
            builder.HasOne(x => x.Dishes).WithMany(m => m.MenuDishes).HasForeignKey(fk => fk.IdDish);
            builder.HasOne(x => x.Categories).WithMany(m => m.MenuDishes)
                .HasForeignKey(fk => fk.IdCategory);
        }
    }
}