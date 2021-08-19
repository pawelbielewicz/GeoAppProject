using GeoApp.Data;
using GeoApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeoApp
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GeoObjectDbContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGeoStoreRepository, GeoStoreRepository>();
            return services;
        }
    }
}
