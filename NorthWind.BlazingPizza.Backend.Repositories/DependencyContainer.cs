using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Repositories.Repositories;

namespace NorthWind.BlazingPizza.Frontend.ViewModels
{
	public static class DependencyContainer
	{
		
		//La funcionalidad de este metodo es agregar los viewModels
		public static IServiceCollection AddRepositories(
			this IServiceCollection services)
		{
			services.AddScoped<IGetSpecialsRepository, GetSpecialsRepository>();
			return services;
		}
	}
}
