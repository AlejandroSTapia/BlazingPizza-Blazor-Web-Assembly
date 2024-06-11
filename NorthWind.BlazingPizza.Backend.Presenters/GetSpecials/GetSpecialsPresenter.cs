using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Presenters.GetSpecials
{
	internal class GetSpecialsPresenter(
		IOptions<BlazingPizzaOptions> options) : IGetSpecialsOutputPort
	{
		public IEnumerable<PizzaSpecialDto> PizzaSpecials 
			{ get; private set; }

		public Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecials)
		{
			//armar toda la ruta sacada desde options
			PizzaSpecials = pizzaSpecials
				.Select(s => new PizzaSpecialDto(
					s.Id, s.Name, s.BasePrice, s.Description,
					$"{options.Value.ImageUrlBase}/{s.ImageUrl}"));

			//ya no hay nada por devolver?
			return Task.CompletedTask;//devolver una tarea que ya fue completada
		}
	}
}
