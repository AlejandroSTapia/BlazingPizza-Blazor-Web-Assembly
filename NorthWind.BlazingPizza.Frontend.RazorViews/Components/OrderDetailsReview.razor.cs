using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class OrderDetailsReview
    {
        [Parameter]
        public GetOrderOrderDto Order { get; set; }
    }
}
