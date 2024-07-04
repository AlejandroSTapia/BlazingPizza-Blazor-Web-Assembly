using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IToppingDataSource
	{
		Task<IEnumerable<ToppingDto>> GetToppingDtosFromQueryAsync(
			//se pasa la consulta por el delegado func recibe y envia params para armar la consulta
			Func<IQueryable<Topping>, IQueryable<ToppingDto>> queryBuilder);//envia y recibe			
	}
}
