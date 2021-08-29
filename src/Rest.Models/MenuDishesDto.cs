using System;
using System.Linq.Expressions;
using Rest.Domain.Entities;

namespace Rest.Models
{
    public class MenuDishesDto
    {
        public int IdDish { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }
        public string CategoryName { get; set; }
        public int IdMenu { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }

        public static implicit operator MenuDishes(MenuDishesDto dto)
        {
            return dto != null
                ? new MenuDishes
                {
                    IdDish = dto.IdDish,
                    IdCategory = dto.IdCategory,
                    Price = dto.Price,
                    IdMenu = dto.IdMenu,
                    Id = dto.Id
                }
                : null;
        }

        public static Expression<Func<MenuDishes, MenuDishesDto>> Projection
        {
            get
            {
                return x => new MenuDishesDto()
                {
                    Price = x.Price,
                    IdCategory = x.IdCategory,
                    IdDish = x.IdDish,
                    IdMenu = x.IdMenu,
                    Id = x.Id,
                    Name = x.Dishes.Name,
                    Description = x.Dishes.Description,
                    CategoryName = x.Categories.Name
                };
            }
        }
    }
}