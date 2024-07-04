using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials
{
    public interface IGetSpecialsOutputPort
	{
		IEnumerable<PizzaSpecialDto> PizzaSpecials { get; }

		//va a manejar y va a devolver el enumerable de; pizzas
		//HandleResultAsync es el presentador y va a formatear el resultado para brindarselo al controlador
		Task HandleResultAsync(IEnumerable<PizzaSpecialDto> pizzaSpecials);
	}
}
