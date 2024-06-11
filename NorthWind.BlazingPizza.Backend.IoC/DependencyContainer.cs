using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Options;
using NorthWind.BlazingPizza.Backend.Presenters.GetSpecials;
using NorthWind.BlazingPizza.Backend.UseCases;
using NorthWind.BlazingPizza.EFCore.DataSources;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Frontend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				.AddPresenters();

			services.Configure(configureBlazingPizzaOptions);

			return services;
		}
	}
}
