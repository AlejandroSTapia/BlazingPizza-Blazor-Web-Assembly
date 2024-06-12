using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
	public interface IToppingDataSource
	{
		Task<IEnumerable<ToppingDto>> GetToppingDtosFromQueryAsync(
			//se pasa la consulta por el delegado func recibe y envia params para armar la consulta
			Func<IQueryable<Topping>, IQueryable<ToppingDto>> queryBuilder);//envia y recibe			
	}
}
