using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rest.Domain.Entities;

namespace Rest.Domain.EntityTypeConfigurations
{
    public class MenusOptionsEntityTypeConfiguration : IEntityTypeConfiguration<MenusOptions>
    {
        public void Configure(EntityTypeBuilder<MenusOptions> builder)
        {
            builder.ToTable(nameof(MenusOptions));
            builder.HasKey(x => new { x.IdMenu, x.IdOption });

            builder.HasOne<Menus>(x => x.Menus).WithMany(m => m.MenuOptions).HasForeignKey(fk => fk.IdMenu);
            builder.HasOne<Options>(x => x.Options).WithMany(m => m.MenuOptions).HasForeignKey(fk => fk.IdOption);
        }
    }
}
