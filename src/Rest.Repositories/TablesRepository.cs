using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class TablesRepository : BaseRepository<Tables>, ITablesRepository
    {
        public TablesRepository(RestContext RestContext) : base(RestContext) { }
    }
}
