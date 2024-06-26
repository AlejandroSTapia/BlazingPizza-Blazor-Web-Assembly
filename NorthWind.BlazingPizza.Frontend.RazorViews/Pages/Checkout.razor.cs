using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.Checkout;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Checkout
    {
        [Inject]
        CheckoutViewModel ViewModel { get; set; }
        [Inject]
        NavigationManager NavigationManager { get; set; }

        async Task Placer()
        {
            await ViewModel.PlaceOrderAsync();
            NavigationManager.NavigateTo("/");
        }
    }
}