using NortWind.BlazzingPizza.Frontend.ViewModels.GetSpecialsPizzasViewModel;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyContainer
{
    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddScoped<GetSpecialsPizzasViewModel>();
        return services;
    }
}