using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.UseCases
{
	internal class GetSpecialsInteractor(IGetSpecialsRepository repository,
		IGetSpecialsOutputPort presenter): IGetSpecialsInputPort
	{
		public async Task GetSpecialsAsync()
		{
			var Special = await repository.GetSpecialsSortedByDescendingPriceAsync();
			await presenter.HandleResultAsync(Special);
		}
	}
}
