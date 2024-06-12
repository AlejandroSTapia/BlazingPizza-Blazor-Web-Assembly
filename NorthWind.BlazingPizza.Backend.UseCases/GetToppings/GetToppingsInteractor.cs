using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetToppings
{
	internal class GetToppingsInteractor(IGetToppingsRepository repository): IGetToppingsInputPort
	{
		public Task<IEnumerable<ToppingDto>> GetToppingsAsync()=>
			repository.GetToppingsSortedNameAscendingAsync(); //se pasa a quien se los pida
	}
}
