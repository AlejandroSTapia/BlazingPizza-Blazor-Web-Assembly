using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Presenters.GetSpecials;

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
