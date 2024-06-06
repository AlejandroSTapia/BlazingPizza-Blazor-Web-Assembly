using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials
{
	public interface IGetSpecialsOutputPort
	{
		IEnumerable<PizzaSpecialDto> PizzaSpecilas { get; }

		//va a manejar y va a devolver el enumerable de; pizzas
		//HandleResultAsync es el presentador y va a formatear el resultado para brindarselo al controlador
		Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecials);
	}
}
