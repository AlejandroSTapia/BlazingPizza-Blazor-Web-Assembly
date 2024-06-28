using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.Repositories.Repositories;

namespace NorthWind.BlazingPizza.Frontend.ViewModels
{
	public static class DependencyContainer
	{
		
		//La funcionalidad de este metodo es agregar los viewModels
		public static IServiceCollection AddRepositories(
			this IServiceCollection services)
		{
			services.AddScoped<IGetSpecialsRepository, GetSpecialsRepository>();

			services.AddScoped<IGetToppingsRepository, GetToppingsRepository>();
			services.AddScoped<IPlaceOrderRepository, PlaceOrderRepository>();
			services.AddScoped<IGetOrdersRepository, GetOrdersRepository>();
			return services;
		}
	}
}
