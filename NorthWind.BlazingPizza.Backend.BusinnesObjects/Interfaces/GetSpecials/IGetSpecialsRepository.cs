using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials
{
    public interface IGetSpecialsRepository
	{
		Task<IEnumerable<PizzaSpecialDto>>GetSpecialsSortedByDescendingPriceAsync();
	}
}
