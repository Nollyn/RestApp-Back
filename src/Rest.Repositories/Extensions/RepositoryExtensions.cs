using Rest.Repositories.Base;
using Rest.Repositories.Contracts.Base;
using Microsoft.Extensions.DependencyInjection;

namespace Rest.Repositories.Extensions
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.Scan(scan =>
                scan.FromAssembliesOf(typeof(BaseRepository<>)).AddClasses(classes => classes.AssignableTo(typeof(IRepository<>)))
                    .AsImplementedInterfaces().WithTransientLifetime());

            serviceCollection.Scan(scan =>
                scan.FromAssembliesOf(typeof(BaseIdentityRepository<>)).AddClasses(classes => classes.AssignableTo(typeof(IIdentityRepository<>)))
                    .AsImplementedInterfaces().WithTransientLifetime());
        }
    }
}
