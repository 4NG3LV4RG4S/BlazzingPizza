using NorthWind.BlazzingPizza.Frontend.WebApiProxies;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddBlazzingPizzaServices(this IServiceCollection services)
    {
        services.AddModels();
        services.AddViewModels();

        return services;
    }
}