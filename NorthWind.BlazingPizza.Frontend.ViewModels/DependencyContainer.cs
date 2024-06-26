using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.ViewModels.Checkout;
using NorthWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog;
using NorthWind.BlazingPizza.Frontend.ViewModels.GetSpecials;
using NorthWind.BlazingPizza.Frontend.ViewModels.Index;

namespace NorthWind.BlazingPizza.Frontend.ViewModels
{
	public static class DependencyContainer
	{
		
		//La funcionalidad de este metodo es agregar los viewModels
		public static IServiceCollection AddViewModels(
			this IServiceCollection services)
		{
			services.AddScoped<GetSpecialsViewModel>();
			services.AddScoped<ConfigurePizzaDialogViewModel>();
			services.AddScoped<IndexViewModel>();
			services.AddScoped<CheckoutViewModel>();
			return services;
		}
	}
}
