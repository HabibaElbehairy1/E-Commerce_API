using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.API
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services ) 
        {
            services.AddControllers();
            return services;
        }
    }
}
