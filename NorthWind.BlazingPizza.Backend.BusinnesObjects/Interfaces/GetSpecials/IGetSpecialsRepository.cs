using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials
{
	public interface IGetSpecialsRepository
	{
		Task<IEnumerable<PizzaSpecialDto>>GetSpecialsSortedByDescendingPriceAsync();
	}
}
