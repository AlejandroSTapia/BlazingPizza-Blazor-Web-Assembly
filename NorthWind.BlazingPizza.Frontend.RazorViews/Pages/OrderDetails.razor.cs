using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.OrderDetails;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class OrderDetails
    {
        [Inject]
        OrderDetailsViewModel ViewModel { get; set; }

        [Parameter]
        public int OrderId { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await ViewModel.GetOrderAsync(OrderId);
        }
    }
}