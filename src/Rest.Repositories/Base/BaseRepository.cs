using Microsoft.EntityFrameworkCore;
using Rest.Domain.Context;
using Rest.Domain.Entities.Base;
using Rest.Repositories.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rest.Repositories.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly RestContext RestContext;

        public async Task<T> Get(int id, params Expression<Func<T, object>>[] includes)
        {
            var query = RestContext.Set<T>().AsNoTracking().Where(p => p.Id == id);
            query = includes.Aggregate(query, (current, item) => current.Include(item));
            return await query.FirstOrDefaultAsync();
        }

        protected BaseRepository(RestContext RestContext)
        {
            this.RestContext = RestContext;
        }

        public async Task<bool> Delete(T entity)
        {
            RestContext.Set<T>().Remove(entity);
            return await RestContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await Get(id);
            if (entity == null)
            {
                return false;
            }

            return await Delete(entity);
        }

        public IQueryable<T> Find(int id)
        {
            return RestContext.Set<T>().Where(p => p.Id == id);
        }

        public async Task<T> Get(int id)
        {
            return await RestContext.Set<T>().AsNoTracking().SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await RestContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T> Insert(T entity)
        {
            await RestContext.Set<T>().AddAsync(entity);
            await RestContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> List(Expression<Func<T, bool>> expression)
        {
            return await RestContext.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        }

        public async Task<bool> Update(T entity)
        {
            RestContext.Set<T>().Update(entity);
            return await RestContext.SaveChangesAsync() > 0;
        }
    }
}