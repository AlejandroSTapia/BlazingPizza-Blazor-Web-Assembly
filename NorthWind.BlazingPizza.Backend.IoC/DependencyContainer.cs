using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Options;
using NorthWind.BlazingPizza.Backend.UseCases;
using NorthWind.BlazingPizza.EFCore.DataSources;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities;
using NorthWind.BlazingPizza.Frontend.ViewModels;

namespace NorthWind.BlazingPizza.Backend.Presenters
{
    public static class DependencyContainer
	{
		//sealed HandleInheritability registrados los servicios
		public static IServiceCollection AddBlazingPizzaServices(
			this IServiceCollection services,
			Action<DBOptions> configureDbOptions, //Action es un delegado
			Action<BlazingPizzaOptions> configureBlazingPizzaOptions)
		{
			services.AddUseCasesServices()
				.AddRepositories()
				.AddDataSources(configureDbOptions)
				.AddPresenters()
				.AddValidators();

			services.Configure(configureBlazingPizzaOptions);

			return services;
		}
	}
}
