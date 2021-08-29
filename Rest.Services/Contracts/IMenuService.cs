using System.Threading.Tasks;
using Rest.Models;

namespace Rest.Services.Contracts
{
    public interface IMenusService
    {
        Task<bool> UpdateWithDishes(MenusDto menus);
    }
}