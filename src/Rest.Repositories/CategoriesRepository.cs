using Rest.Domain.Context;
using Rest.Domain.Entities;
using Rest.Repositories.Base;
using Rest.Repositories.Contracts;

namespace Rest.Repositories
{
    public class CategoriesRepository : BaseRepository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(RestContext RestContext) : base(RestContext) { }
    }
}
