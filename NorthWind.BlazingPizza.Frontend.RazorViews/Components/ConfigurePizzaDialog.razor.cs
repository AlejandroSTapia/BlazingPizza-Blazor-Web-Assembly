using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Agregates;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.ViewModels.ConfigurePizzaDialog;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class ConfigurePizzaDialog
    {
        [Inject]
        ConfigurePizzaDialogViewModel ViewModel { get; set; }
        [Inject]
        IOptions<BlazingPizzaOptions> Options { get; set; }
        [Parameter]
        public CustomPizza CustomPizza { get; set; }
        [Parameter]
        public EventCallback OnCancel { get; set; }
        [Parameter]
        public EventCallback OnConfirm { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetToppingsAsync();
        }

        void ToppingSelected(ChangeEventArgs e) =>
            CustomPizza.AddTopping(
                ViewModel.Toppings
                    .First(t => t.Id == Convert.ToInt32(e.Value)));
    }
}