using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetSpecials;
using NorthWind.BlazingPizza.Frontend.WebApiProxies.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies
{
	//Aqui se registran las dependencias
	public static class DependencyContainer
	{
		//este proyecto agrega modelos
		//AddModels metodo de extension para reguistrar las implementacioones
		public static IServiceCollection AddModels(this IServiceCollection services,
			Action<HttpClient> configureGetSpecialsModelHttpClient,
			Action<IHttpClientBuilder> getSpecialsHttpClientBuilder,
			Action<HttpClient> configureGetToppingsModelHttpClient,
			Action<IHttpClientBuilder> getToppingsHttpClientBuilder)//configurador
		{
			// Se debe implementar el servicio y registrarlo en la coleccion de servcios del contendedor de inyeccion
			//services.AddScoped<IGetSpecialsModel, GetSpecialsModel>();

			//Con esto se agrega el cliente
			IHttpClientBuilder Builder = services
				.AddHttpClient<IGetSpecialsModel, GetSpecialsModel>(configureGetSpecialsModelHttpClient);

			//seguridad de tokens?
			getSpecialsHttpClientBuilder?.Invoke(Builder);

			IHttpClientBuilder GetToppingsBuilder = services
				.AddHttpClient<IGetToppingsModel, GetToppingsModel>(configureGetToppingsModelHttpClient);

			getToppingsHttpClientBuilder?.Invoke(Builder);


			return services;
		}
	}

	//fabricas de clientes https para enviar unhttpCLient bien estructurado y configurado
	//Con eso ya se puede construir clients hhtp

}
