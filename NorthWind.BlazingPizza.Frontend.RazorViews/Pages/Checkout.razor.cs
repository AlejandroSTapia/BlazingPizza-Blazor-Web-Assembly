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
