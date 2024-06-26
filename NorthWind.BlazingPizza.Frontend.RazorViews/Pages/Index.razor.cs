using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;
using NorthWind.BlazingPizza.Frontend.ViewModels.Index;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Pages
{
    public partial class Index
    {
        [Inject]
        IndexViewModel ViewModel { get; set; }

        [Inject]
        ShoppingCart ShoppingCart { get; set; }
    }
}