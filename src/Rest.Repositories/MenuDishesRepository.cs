using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class MenuDishesRepository : BaseRepository<MenuDishes>, IMenuDishesRepository
    {
        public MenuDishesRepository(RestContext RestContext) : base(RestContext)
        {
        }
    }
}