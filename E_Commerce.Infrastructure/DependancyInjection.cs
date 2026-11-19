using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) 
        {
            //services.AddDbContext<StoreDbContext>(Options =>
            //{
            //    Options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            //});
            return services;
        }
    }
}
