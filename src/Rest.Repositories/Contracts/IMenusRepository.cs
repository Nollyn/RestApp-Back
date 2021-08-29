using System.Threading.Tasks;
using Rest.Domain.Entities;
using Rest.Models;
using Rest.Repositories.Contracts.Base;

namespace Rest.Repositories.Contracts
{
    public interface IMenusRepository : IRepository<Menus>
    {
        //Task<List<RestaurantsMenus>> GetByRestaurant(int idRestaurant);
        Task<MenusDto> GetWithDetails(int resultId);
        Task<MenusDto> InsertAndReturn(MenusDto menus);
        Task<bool> UpdateWithDishes(Menus dto);
    }
}