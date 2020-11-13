using AspNetCoreFromScratch.Services;
using AspNetCoreFromScratch.Services.Impls;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreFromScratch
{
    public static class StylizationServicesExtension
    {
        public static IServiceCollection AddStylization(this IServiceCollection services, IConfiguration cfg)
        {
            services.Configure<ColorOptions>(cfg.GetSection("Colors"));
            services.AddSingleton<IStyles>(new StandardStyles());
            
            return services;
        }
    }
}