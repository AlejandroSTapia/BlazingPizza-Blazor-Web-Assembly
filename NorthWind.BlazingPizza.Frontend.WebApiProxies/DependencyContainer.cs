using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetSpecials;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies
{
	//Aqui se registran las dependencias
	public static class DependencyContainer
	{
		//este proyecto agrega modelos
		//AddModels metodo de extension para reguistrar las implementacioones
		public static IServiceCollection AddModels(this IServiceCollection services)
		{
			// Se debe implementar el servicio y registrarlo en la coleccion de servcios del contendedor de inyeccion
			services.AddScoped<IGetSpecialsModel, GetSpecialsModel>();
			return services;
		}
	}
}
