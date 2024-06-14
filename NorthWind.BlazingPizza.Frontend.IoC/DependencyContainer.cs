
using NorthWind.BlazingPizza.Frontend.BusinessObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.ViewModels;
using NorthWind.BlazingPizza.Frontend.WebApiProxies;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
	public static IServiceCollection AddBlazingPizzaServices(
		this IServiceCollection services,
		Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
	{
		BlazingPizzaOptions BlazingPizzaOptions = new();
		configureBlazingPizzaOptions(BlazingPizzaOptions);//aqui se pidn las opciones

		Uri WebApiUri = new Uri(BlazingPizzaOptions.WebApiBaseAddress);

		//services.AddModels();
		services.AddModels(
			httpClient => httpClient.BaseAddress = WebApiUri,
			//new Uri(BlazingPizzaOptions.WebApiBaseAddress),
			null,
			httpClient => httpClient.BaseAddress = WebApiUri,
			//new Uri(BlazingPizzaOptions.WebApiBaseAddress),
			null
			);

		services.AddViewModels();

		services.AddSingleton(Options.Options.Create(BlazingPizzaOptions));
		services.AddBusinessObjectsServices();

		return services;
	}
}
