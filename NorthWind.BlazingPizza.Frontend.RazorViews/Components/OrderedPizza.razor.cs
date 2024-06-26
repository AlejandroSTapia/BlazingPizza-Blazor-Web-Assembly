using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Agregates;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class OrderedPizza
    {
        [Parameter]
        public CustomPizza CustomPizza { get; set; }
        
        [Parameter]
        public EventCallback OnRemoved { get; set; }

    }
}