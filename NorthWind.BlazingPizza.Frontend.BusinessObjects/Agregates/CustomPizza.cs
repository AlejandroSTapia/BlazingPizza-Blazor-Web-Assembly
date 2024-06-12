using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Agregates
{
	public class CustomPizza
	{
		//que bj va a icluir este agregado?
		readonly List<ToppingDto> ToppingsField = [];

		//debe partir d euna pizza base, para ello el const
		public CustomPizza(PizzaSpecialDto special,
			BlazingPizzaOptions options) {
			Special = special;
			Options = options;
			Size = Options.DefaultPizzaSize;
		}

		public PizzaSpecialDto Special { get; }
		public BlazingPizzaOptions Options { get; }
		public int Size { get; set; }

		//para exponer los topincs al exterior, solo una mascara
		public IEnumerable<ToppingDto> Toppings => ToppingsField;

		public bool HasMaximumToppings =>
			ToppingsField.Count >= Options.MaximumCustomPizzaToppings;

		//para no repetir los ingredientes, con uso del agregado(la clase)
		public void AddTopping(ToppingDto topping)
		{
			if (!ToppingsField.Contains(topping))
			{
				ToppingsField.Add(topping);
			}
		}

		//eliminar topings
		public void RemoveTopping(ToppingDto topping) =>
			ToppingsField.Remove(topping);

		//Determinar los precios base
		public decimal GetBasePrice() =>
			(decimal) Size / Options.DefaultPizzaSize * Special.BasePrice;

		//precio total que sera con la suma de los toppings
		public decimal GetTotalPrice()=>
			GetBasePrice() + ToppingsField.Sum(p => p.Price);

		public string GetFormattedTotalPrice() =>
			GetTotalPrice().ToString("$ 0.00");

		public string GetFormattedSizeWithTotalPrice() =>
			$"{Size} cm ({GetFormattedTotalPrice})";
	}
}
