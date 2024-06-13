using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using System.Net.Http.Json;

//Puente para consumir desde el front el back de la API  - Modelo de la app 


//aqui ya viene el como voya devolver la lista de productos
namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.GetSpecials
{
	internal class GetSpecialsModel(HttpClient client): IGetSpecialsModel //se depende de la interfaz, no de la implementacion
		//Con eso se logra un  desacoplamiento
	{
		//IEnumerable<PizzaSpecialDto> Specials = []; //se borra porque lo descargado ya implementara esto

		//en su lugar implementamos que detectte el archiuvi
		IEnumerable<PizzaSpecialDto> Specials;
		
		//lanzar una peticion a la webApi en lugar de usar los datos en un IEnumberable grande en duro

		//Codigo de la web api para consumir los datos
		//con esto ya esta implementado el modelo
		public async Task<IEnumerable<PizzaSpecialDto>> GetSpecialsAsync()
		//=>
		//await Task.FromResult(Specials.OrderByDescending(s => s.BasePrice));
		{
			if (Specials == null)
			{
				Specials = await client.GetFromJsonAsync<IEnumerable<PizzaSpecialDto>>(
					Endpoints.GetSpecials);
			}
			return Specials; //Tambien servira como cache
		}
		
	}
}
