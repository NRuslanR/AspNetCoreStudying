using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Application.Services.Books;
using WebAPI.Application.Services.Books.Impls;

namespace WebAPI.Services_Extensions.Books
{
    public static class BookServicesExtensions
    {
        public static IServiceCollection AddBookServices(this IServiceCollection services)
        {
            services.AddScoped<IBookAccountingService, FakeInMemoryBookAccountingService>();

            return services;
        }
    }
}