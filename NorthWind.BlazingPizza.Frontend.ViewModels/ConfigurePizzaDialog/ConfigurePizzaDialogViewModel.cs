using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetToppings;


namespace NorthWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog
{
	public class ConfigurePizzaDialogViewModel(
		IGetToppingsModel toppingsModel)
	{
		public IEnumerable<ToppingDto> Toppings { get; private set; }
		public async Task GetToppingsAsync() =>
			Toppings = await toppingsModel.GetToppingsAsync();
	}
}
