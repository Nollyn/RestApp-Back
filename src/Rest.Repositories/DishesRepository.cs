using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class DishesRepository : BaseRepository<Dishes>, IDishesRepository
    {
        public DishesRepository(RestContext RestContext) : base(RestContext) { }
    }
}
