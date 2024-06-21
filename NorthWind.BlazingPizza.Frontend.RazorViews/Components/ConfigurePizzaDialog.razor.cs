using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Agregates;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class ConfigurePizzaDialog: ComponentBase
    {
        [Inject]
        ConfigurePizzaDialogViewModel ViewModel { get; set; }
        [Inject]
        IOptions<BlazingPizzaOptions> Options { get; set; }
        [Parameter]
        public CustomPizza CustomPizza { get; set; }
        [Parameter]
        public EventCallback OnCancel { get; set; } //llamada de regreso
        [Parameter]
        public EventCallback OnConfirm { get; set; }

        //manejador de evento cuadno se inicialice
        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetToppingsAsync();
        }

        //cuando se seleccione un topping
        void ToppingSelected(ChangeEventArgs e) =>
            CustomPizza.AddTopping( //CustomPizza.AddTopping es un agregado y su proposito es que proteja o add logica de los datos(validaciones)
                ViewModel.Toppings
                .First(t => t.Id == Convert.ToInt32(e.Value)));

        //Se coloca aqui en el code begin y no en el viewmodel. por el changeEvent
    }
}