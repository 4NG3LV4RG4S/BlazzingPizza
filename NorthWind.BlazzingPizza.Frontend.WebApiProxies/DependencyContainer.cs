using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazzingPizza.Frontend.BussinessObjects.Interfaces.GetSpecialPizzasInterfaces;
using NorthWind.BlazzingPizza.Frontend.WebApiProxies.GetSpecialsPizzasProxys;

namespace NorthWind.BlazzingPizza.Frontend.WebApiProxies;

public static class DependencyContainer
{
    public static IServiceCollection AddModels(this IServiceCollection services)
    {
        services.AddScoped<IGetSpecialsPizzasModel, GetSpecialPizzasModel>();
        return services;
    } 
}