using E_Commerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services ,IConfiguration config) 
        {
            services.AddDbContext<StoreDbContext>(Options =>
            {
                Options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
                        .EnableSensitiveDataLogging();
            });
            return services;
        }
    }
}
