using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings
{
    public interface IGetToppingsModel
	{
		Task<IEnumerable<ToppingDto>> GetToppingsAsync();
	}

}
