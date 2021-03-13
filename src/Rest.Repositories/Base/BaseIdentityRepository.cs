using Rest.Domain.Context;
using Rest.Domain.Entities.Base;
using Rest.Repositories.Contracts.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rest.Repositories.Base
{
    public class BaseIdentityRepository<T>:IIdentityRepository<T> where T:BaseIdentityEntity
    {
        private readonly RestContext RestContext;

        public BaseIdentityRepository(RestContext RestContext)
        {
            this.RestContext = RestContext;
        }

        public async Task<bool> Delete(T entity)
        {
            this.RestContext.Set<T>().Remove(entity);
            return await this.RestContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(string id)
        {
            var entity = await this.Get(id);
            if (entity == null)
            {
                return false;
            }
            return await this.Delete(entity);
        }

        public async Task<T> Get(string id)
        {
            return await this.RestContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.RestContext.Set<T>().ToListAsync();
        }

        public async Task<T> Insert(T entity)
        {
            await this.RestContext.Set<T>().AddAsync(entity);
            await this.RestContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> List(Expression<Func<T, bool>> expression)
        {
            return await this.RestContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        }

        public async Task<bool> Update(T entity)
        {
            this.RestContext.Set<T>().Update(entity);
            return await this.RestContext.SaveChangesAsync() > 0;
        }
    }
}
