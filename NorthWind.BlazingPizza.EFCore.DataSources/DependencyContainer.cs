using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.DataSources;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources
{
	public static class DependencyContainer
	{
	public static IServiceCollection AddDataSources(
		this IServiceCollection services,
		Action<DBOptions> configureDBOptions)
	{
		services.AddScoped<IPizzaSpecialDataSource, PizzaSpecialDataSource>();

			services.AddScoped<IToppingDataSource, ToppingDataSource>();

		services.Configure(configureDBOptions);

			services.AddScoped<IPlaceOrderDataSource, PlaceOrderDataSource>();
		return services;
	}
   }
}
