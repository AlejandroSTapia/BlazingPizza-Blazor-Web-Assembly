using NorthWind.BlazingPizza.Frontend.ViewModels;
using NorthWind.BlazingPizza.Frontend.WebApiProxies;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
	public static IServiceCollection AddBlazingPizzaServices(
		this IServiceCollection services)
	{
		services.AddModels();
		services.AddViewModels();
		return services;
	}
}
