using System.Threading.Tasks;
using Rest.Models;
using Rest.Repositories.Contracts;
using Rest.Services.Contracts;

namespace Rest.Services
{
    public class MenusService : IMenusService
    {
        private readonly IMenusRepository _menusRepository;

        public MenusService(IMenusRepository menusRepository)
        {
            _menusRepository = menusRepository;
        }

        public async Task<bool> UpdateWithDishes(MenusDto menus)
        {
            return await _menusRepository.UpdateWithDishes(menus);
        }
    }
}