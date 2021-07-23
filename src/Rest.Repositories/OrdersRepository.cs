using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(RestContext RestContext) : base(RestContext) { }
    }
}
