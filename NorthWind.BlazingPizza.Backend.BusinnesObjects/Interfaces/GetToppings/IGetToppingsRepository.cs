using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings
{
	public interface IGetToppingsRepository
	{
		Task<IEnumerable<ToppingDto>> GetToppingsSortedNameAscendingAsync();
	}
}
