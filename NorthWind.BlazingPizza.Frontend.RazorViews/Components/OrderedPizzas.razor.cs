using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class OrderedPizzas
    {
        [Parameter]
        public ShoppingCart ShoppingCart { get; set; }
    }
}