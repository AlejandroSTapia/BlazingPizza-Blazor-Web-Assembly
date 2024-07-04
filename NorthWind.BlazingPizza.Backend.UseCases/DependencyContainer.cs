using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrder;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.UseCases.GetOrder;
using NorthWind.BlazingPizza.Backend.UseCases.GetOrders;
using NorthWind.BlazingPizza.Backend.UseCases.GetSpecials;
using NorthWind.BlazingPizza.Backend.UseCases.GetToppings;
using NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.UseCases
{
    public static class DependencyContainer
	{
		public static IServiceCollection AddUseCasesServices(
			this IServiceCollection services)
		{
			services.AddScoped<IGetSpecialsInputPort, GetSpecialsInteractor>();

			services.AddScoped<IGetToppingsInputPort, GetToppingsInteractor>();

			services.AddScoped<IPlaceOrderInputPort, PlaceOrderInteractor>();

			services.AddScoped<IGetOrdersInputPort, GetOrdersInteractor>();
			services.AddScoped<IGetOrderInputPort, GetOrderInteractor>();

			return services;
		}
	}
}
