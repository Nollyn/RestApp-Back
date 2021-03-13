using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class DrinksRepository : BaseRepository<Drinks>, IDrinksRepository
    {
        public DrinksRepository(RestContext RestContext) : base(RestContext) { }
    }
}
