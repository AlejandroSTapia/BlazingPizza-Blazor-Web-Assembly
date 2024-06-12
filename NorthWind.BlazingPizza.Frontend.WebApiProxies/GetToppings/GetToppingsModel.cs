using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.GetToppings
{
	//invocar a la webapi
	internal class GetToppingsModel(HttpClient client) : IGetToppingsModel
	{
		IEnumerable<ToppingDto> Toppings;

		public async Task<IEnumerable<ToppingDto>> GetToppingsAsync()
		{
			if (Toppings == null)
			{
				Toppings = await client
					.GetFromJsonAsync<IEnumerable<ToppingDto>>(
					Endpoints.GetToppings);
			}
		}
	}
}
