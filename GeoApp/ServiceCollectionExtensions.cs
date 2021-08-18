using GeoApp.Data;
using GeoApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
