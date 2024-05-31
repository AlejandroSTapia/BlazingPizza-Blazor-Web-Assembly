using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.ViewModels;
using NorthWind.BlazingPizza.Frontend.WebApiProxies;

namespace NorthWind.BlazingPizza.Frontend.IoC
{
	public static class DependencyContainer
	{
		public static IServiceCollection AddFrontendServices(
			this IServiceCollection services)
		{
			services.AddModels();
			services.AddViewModels();
			return services;
		}
	}
}
