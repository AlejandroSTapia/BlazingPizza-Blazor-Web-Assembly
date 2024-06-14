using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.UseCases.GetSpecials;
using NorthWind.BlazingPizza.Backend.UseCases.GetToppings;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
