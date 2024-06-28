
using NorthWind.BlazingPizza.Frontend.BusinessObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.ViewModels;
using NorthWind.BlazingPizza.Frontend.WebApiProxies;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.Common;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
	public static IServiceCollection AddBlazingPizzaServices(
		this IServiceCollection services,
		Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
	{
		BlazingPizzaOptions BlazingPizzaOptions = new();
		configureBlazingPizzaOptions(BlazingPizzaOptions);//aqui se pidn las opciones


		//Se agregan los modelos
		//services.AddModels();
		services.AddModels(BlazingPizzaOptions);

		services.AddViewModels();

		services.AddSingleton(Options.Options.Create(BlazingPizzaOptions));
		services.AddBusinessObjectsServices();

		return services;
	}

	//configurador de modelos de la webapi, que usaran este mismo todos los modelos
	static IServiceCollection AddModels(this IServiceCollection services,
		BlazingPizzaOptions options)
	{
		Uri WebApiUri = new Uri(options.WebApiBaseAddress);
		var Configurator = new HttpClientConfigurator(
			httpClient => httpClient.BaseAddress = WebApiUri, null);

		services.AddModels(Configurator, Configurator, Configurator);

		return services;
	}
}
