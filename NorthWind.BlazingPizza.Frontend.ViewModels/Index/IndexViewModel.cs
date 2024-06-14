using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Agregates;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Index
{
	public class IndexViewModel(IOptions<BlazingPizzaOptions> options)
	{
		public CustomPizza CustomPizza { get; set; }
		public bool ShowConfigurePizzaDialog { get; set; }//bandera paraindicar el momento para mostrar el cuadro de dialog de perzona
		public void ConfigurePizza(PizzaSpecialDto special)
		{
			CustomPizza = new CustomPizza(special, options.Value);
			ShowConfigurePizzaDialog = true; //para que muestre el cuadrode dialog
		}

		public void CancelConfigurePizza()
		{
			CustomPizza = null;
			ShowConfigurePizzaDialog = false;
		}

		public void ConfirmConfigurePizza()
		{
			//carrito
			CustomPizza = null;
			ShowConfigurePizzaDialog = false;
		}
	}
}
