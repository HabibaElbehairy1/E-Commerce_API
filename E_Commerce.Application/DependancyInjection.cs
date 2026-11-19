using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.Application
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services ) 
        {
            return services;
        }
    }
}
