using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class ExtrasRepository : BaseRepository<Extras>, IExtrasRepository
    {
        public ExtrasRepository(RestContext RestContext) : base(RestContext) { }
    }
}
