using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class restaurantsRepository : BaseRepository<Restaurants>, IRestaurantsRepository
    {
        public restaurantsRepository(RestContext RestContext) : base(RestContext) { }
    }
}
