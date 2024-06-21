using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using NorthWind.BlazingPizza.Frontend.ViewModels.GetSpecials;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
	public partial class Specials: ComponentBase
	{
		//la vista no habla con el modelo, si no con el viewModel, pr ello se debe hacer una instancia del viewmodel
		//De esta forma recibo la dependencia, indicandole que se va a injectar del viewmodl
		[Inject]
		GetSpecialsViewModel ViewModel { get; set; }

		//notificar a nuestro padre conun evento
		[Parameter]
		public EventCallback<PizzaSpecialDto> OnClickSpecial { get; set; }

		//ideal para ir por los datos
		//el override cuando el componente se incializa(omponenete, etc)
		override protected async Task OnInitializedAsync()
		{
			await ViewModel.GetSpecialsAsync();
		}
	}
}