using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.Checkout;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Checkout
    {
        [Inject]
        CheckoutViewModel viewModel { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }

        async Task PlacerOrder()
        {
            await viewModel.PlaceOrderAsync();
            navigationManager.NavigateTo("/");
        }
    }
}
