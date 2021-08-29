using Microsoft.Extensions.DependencyInjection;
using Rest.Services.Contracts;

namespace Rest.Services.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMenusService, MenusService>();
        }
    }
}