using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.Dtos.GetToppings
{
	public class ToppingDto(int id, string name, decimal price)
	{
		public int Id => id;
		public string Name => name;
		public decimal Price => price;

		//se debe mostrar la info en la interfacx
		public string GetFormattedPrice() =>
			price.ToString("0.00");
		public string GetFormattedNameWithPrice() =>
			$"{name} - ({GetFormattedPrice()})";
	}
}
