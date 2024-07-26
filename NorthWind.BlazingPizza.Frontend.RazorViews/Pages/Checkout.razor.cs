using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using NorthWind.BlazingPizza.Frontend.ViewModels.Checkout;
using NorthWind.BlazingPizza.Frontend.ViewModels.Common;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Checkout
    {
        [Inject]
        CheckoutViewModel ViewModel { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        //Esto podria haber ido en el viewmodel, pero el vm no esta casado con blazor y no conoce EditContext
        //por eso mejor se hara hasta que vaya a pasar el pedido    -   Interceptor para invocar al Placeorder
        async Task CheckSubmission(EditContext context)
        {
            if (ViewModel.ValidateAddress(
                context.Model as AddressViewModel))
            {
                await PlaceOrder();
            } 
        }

        async Task PlaceOrder()
        {
            // await viewModel.PlaceOrderAsync();
            int OrderId = await ViewModel.PlaceOrderAsync();
            //navigationManager.NavigateTo("/");
            NavigationManager.NavigateTo($"orderdetails/{OrderId}");
        
        }
    }
}
