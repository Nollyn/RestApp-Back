using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Repositories
{
    public class MenusRepository : BaseRepository<Menus>, IMenusRepository
    {
        //private readonly RestContext restContext;
        public MenusRepository(RestContext RestContext) : base(RestContext) 
        {
            //this.restContext = RestContext;
        }

        //public async Task<List<RestaurantsMenus>> GetByRestaurant(int idRestaurant)
        //{
        //    return await this.restContext.RestaurantsMenus.Where(x => x.IdRestaurant == idRestaurant).ToListAsync();
        //}

    }
}
