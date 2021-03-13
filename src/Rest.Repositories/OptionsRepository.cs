using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class OptionsRepository : BaseRepository<Options>, IOptionsRepository
    {
        public OptionsRepository(RestContext RestContext) : base(RestContext) { }
    }
}
