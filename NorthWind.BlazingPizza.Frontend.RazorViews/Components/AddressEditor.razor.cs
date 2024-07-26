using Microsoft.AspNetCore.Components;
using NorthWind.BlazingPizza.Frontend.ViewModels.Common;

namespace NorthWind.BlazingPizza.Frontend.RazorViews.Components
{
    public partial class AddressEditor
    {
        [Parameter]
        public AddressViewModel ViewModel { get; set; }

        //por ahora ya no tendra el focus, porque se cambio a inputText
        //ElementReference NameInput;

        //protected override async Task OnAfterRenderAsync(bool firstRender) //solo vale true cuando se renderiza la 1ra vez que se renderiza el compoenente
        //{
        //    if (firstRender)
        //    {
        //        await NameInput.FocusAsync();//para dar enfoque al componente
        //    }
        //}
    }
}