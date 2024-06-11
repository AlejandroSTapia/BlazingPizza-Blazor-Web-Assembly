using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Presenters.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Presenters
{
	public static class DependencyContainers
	{
		public static IServiceCollection AddPresenters(
			this IServiceCollection services)
		{
			services.AddScoped<IGetSpecialsOutputPort,
				GetSpecialsPresenter>();
			return services;
		}
	}
}
