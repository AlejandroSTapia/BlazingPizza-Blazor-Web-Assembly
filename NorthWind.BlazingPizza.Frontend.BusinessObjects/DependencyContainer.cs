using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects
{
    public static class DependencyContainer
	{
		public static IServiceCollection AddBusinessObjectsServices(
			this IServiceCollection services)
		{
			services.AddScoped<ShoppingCart>();

			return services;
		}
	}
}
