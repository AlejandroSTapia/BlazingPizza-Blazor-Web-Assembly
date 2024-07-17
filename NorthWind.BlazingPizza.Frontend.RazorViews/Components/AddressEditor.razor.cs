using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.Common;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class AddressEditor
    {
        [Parameter]
        public AddressViewModel ViewModel { get; set; }
    }
}