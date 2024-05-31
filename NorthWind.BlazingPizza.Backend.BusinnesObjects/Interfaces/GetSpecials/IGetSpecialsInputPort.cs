using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials
{
	public interface IGetSpecialsInputPort
	{
		//que se quiere de esta abstraccion?, hacer solo la llamada
		Task GetSpecialsAsync();
	}
}
