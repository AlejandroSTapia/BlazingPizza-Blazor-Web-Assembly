using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings
{
	public interface IGetToppingsInputPort
	{
		Task<IEnumerable<ToppingDto>> GetToppingsAsync();
	}
}
