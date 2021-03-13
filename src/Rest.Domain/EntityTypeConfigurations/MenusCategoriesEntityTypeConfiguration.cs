using Rest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class MenusCategoriesEntityTypeConfiguration : IEntityTypeConfiguration<MenusCategories>
    {
        public void Configure(EntityTypeBuilder<MenusCategories> builder)
        {
            builder.ToTable(nameof(MenusCategories));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName(@"IdMenuCategory");

            builder.HasOne<Menus>(x => x.Menus).WithMany(m => m.MenusCategories).HasForeignKey(fk => fk.IdMenu);
            builder.HasOne<Categories>(x => x.Categories).WithMany(m => m.MenusCategories).HasForeignKey(fk => fk.IdCategory);
        }
    }
}
