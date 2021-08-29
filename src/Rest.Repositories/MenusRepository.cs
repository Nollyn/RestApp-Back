using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Models;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class MenusRepository : BaseRepository<Menus>, IMenusRepository
    {
        private readonly RestContext restContext;

        public MenusRepository(RestContext RestContext) : base(RestContext)
        {
            this.restContext = RestContext;
        }

        public Task<MenusDto> GetWithDetails(int resultId)
        {
            return this.restContext.Menus.Where(p => p.Id == resultId).Select(MenusDto.Projection)
                .SingleOrDefaultAsync();
        }

        public async Task<MenusDto> InsertAndReturn(MenusDto menus)
        {
            var entity = await this.Insert(menus);
            return await this.GetWithDetails(entity.Id);
        }

        public async Task<bool> UpdateWithDishes(Menus dto)
        {
            var menuEntity = await restContext.Menus
                .Include(i => i.MenuDishes)
                .SingleOrDefaultAsync(p => p.Id == dto.Id);

            if (menuEntity == null)
            {
                return false;
            }

            foreach (var menuMenuDish in dto.MenuDishes)
            {
                var menuDishesEntity = menuEntity.MenuDishes.SingleOrDefault(p => p.Id == menuMenuDish.Id);

                if (menuDishesEntity != null)
                {
                    menuDishesEntity.Price = menuMenuDish.Price;
                    menuDishesEntity.IdCategory = menuMenuDish.IdCategory;
                    menuDishesEntity.IdDish = menuMenuDish.IdDish;

                    restContext.Entry(menuDishesEntity).State = EntityState.Modified;
                }
                else
                {
                    menuEntity.MenuDishes.Add(menuMenuDish);
                }
            }

            restContext.Menus.Update(menuEntity);

            var result = await restContext.SaveChangesAsync();

            return result > 0;
        }
    }
}