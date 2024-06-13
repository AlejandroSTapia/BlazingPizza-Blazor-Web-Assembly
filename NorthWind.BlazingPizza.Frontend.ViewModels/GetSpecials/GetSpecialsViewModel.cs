using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.GetSpecials
{
	//El proposito de GetSpecialsViewModel es:
		//exponer los datos a la vista
			//para eso necesita un modelo:
	public class GetSpecialsViewModel(IGetSpecialsModel model) //se pide la dependencia 
	{
		//a la vista le voy a ofecer una colccion de dto
		//Este va a consumir la vista:
		public IEnumerable<PizzaSpecialDto> Specials { get; private set; }

		//ofrecerle al usuario un mtd que no devuleva nada y decir solo que vaya por las pixxas:
		public async Task GetSpecialsAsync()
		{
			Specials = await model.GetSpecialsAsync();
		}

		//public string GetFormatterBasePrice(decimal basePrice) =>
		//	basePrice.ToString("0.00");

		
	}
	//Luego seria registrar el servicio GetSpecialsViewModel
	 // :
	//Se implementara el viewModel con el DependencuCntainer
}
