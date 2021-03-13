using Rest.Domain.Entities;
using Rest.Repositories.Contracts.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Rest.Repositories.Contracts
{
    public interface IMenusRepository : IRepository<Menus>
    {
        //Task<List<RestaurantsMenus>> GetByRestaurant(int idRestaurant);
    }
}
