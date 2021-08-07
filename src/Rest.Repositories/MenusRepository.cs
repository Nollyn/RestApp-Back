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
    }
}