using Microsoft.Extensions.DependencyInjection;
using MediatR;

namespace AspNetCoreJavaScriptServicesGettingStarted
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddCustomMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(Startup));
            return services;
        }
    }
}
