using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetToppingsRepository(
		IToppingDataSource dataSource) : IGetToppingsRepository
	{
		public Task<IEnumerable<ToppingDto>> GetToppingsSortedNameAscendingAsync() =>
		//devolver el datasource
		dataSource.GetToppingDtosFromQueryAsync(
			//se pasa el delegado
			toppings =>
			toppings
			.OrderBy(t => t.Name)
			.Select(t => new ToppingDto(
				t.Id, t.Name, t.Price)));
	}
}
