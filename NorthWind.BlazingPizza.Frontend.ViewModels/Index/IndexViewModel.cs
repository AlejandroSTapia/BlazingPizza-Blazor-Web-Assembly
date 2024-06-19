using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Agregates;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Index
{
	public class IndexViewModel(IOptions<BlazingPizzaOptions> options,
		ShoppingCart shoppingCart)
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
			//agregar al carrito
			shoppingCart.AddPizza(CustomPizza);

			//Codigo temporal para verfificar que se estan agregando las pizzas
			foreach(var Pizza in shoppingCart.Pizzas)
			Console.WriteLine(Pizza.Special.Name);
		

			CustomPizza = null;//se inicializa en null para la prox pizza
			ShowConfigurePizzaDialog = false;
		}
	}
}
