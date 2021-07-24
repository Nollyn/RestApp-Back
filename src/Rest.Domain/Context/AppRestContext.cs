using Rest.Domain.Entities;
using Rest.Domain.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Rest.Domain.Context
{
    public class RestContext : DbContext
    {
        public RestContext(DbContextOptions<RestContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<Extras> Extras { get; set; }
        public DbSet<Drinks> Drinks { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<RestaurantsMenus> RestaurantsMenus { get; set; }
        public DbSet<MenusOptions> MenusOptions { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Dishes> Dishes { get; set; }
        public DbSet<DishesOptions> DishesOptions { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<DrinksOptions> DrinksOptions { get; set; }
        public DbSet<OrdersDiches> OrdersDiches { get; set; }
        public DbSet<OrdersDrinks> OrdersDrinks { get; set; }
        public DbSet<MenuDishes> MenuDishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExrasEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DrinksEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OptionsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantsMenusEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MenusEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DrinksOptionsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DishesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DishesOptionsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TablesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MenusOptionsEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersDishesEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersDrinksEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrdersEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MenuDishesEntityTypeConfiguration());
        }
    }
}
