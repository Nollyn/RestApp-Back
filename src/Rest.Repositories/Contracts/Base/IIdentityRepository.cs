using Rest.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rest.Repositories.Contracts.Base
{
    public interface IIdentityRepository<T> where T : BaseIdentityEntity
    {
        Task<T> Get(string id);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> List(Expression<Func<T, bool>> expression);
        Task<T> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Delete(string id);
    }
}
