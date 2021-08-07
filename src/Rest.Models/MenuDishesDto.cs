using System;
using System.Linq.Expressions;
using Rest.Domain.Entities;

namespace Rest.Models
{
    public class MenuDishesDto
    {
        public int IdDish { get; set; }
        public int IdCategory { get; set; }
        public int IdMenu { get; set; }
        public decimal Price { get; set; }

        public static implicit operator MenuDishes(MenuDishesDto dto)
        {
            return dto != null
                ? new MenuDishes
                {
                    IdDish = dto.IdDish,
                    IdCategory = dto.IdCategory,
                    Price = dto.Price,
                    IdMenu = dto.IdMenu
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
                };
            }
        }
    }
}