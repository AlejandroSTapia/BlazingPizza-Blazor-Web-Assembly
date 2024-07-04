using NorthWind.BlazingPizza.Frontend.ViewModels.Orders;
using Microsoft.AspNetCore.Components;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Orders
    {
        [Inject]
        OrdersViewModel ViewModel { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await ViewModel.GetOrdersAsync();
        }

    }
}