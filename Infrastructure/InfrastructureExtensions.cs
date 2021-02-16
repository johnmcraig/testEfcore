using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }
    }
}