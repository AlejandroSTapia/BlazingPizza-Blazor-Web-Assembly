using NorthWind.BlazingPizza.Entities.Dtos.Common;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;
using NorthWind.BlazingPizza.Frontend.ViewModels.Common;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Checkout
{
    public class CheckoutViewModel(
        ICheckoutModel model,
        ShoppingCart shoppingCart)
    {
        public bool IsSubmitting { get; set; }
        public AddressViewModel AddressViewModel { get; private set; } = new AddressViewModel();
        public async Task<int> PlaceOrderAsync()
        {
            IsSubmitting = true;

            shoppingCart.DeliveryAddress = (AddressDto)AddressViewModel; //cast explicito que se implemento (explicit operator) en el viewmodel, con eso ya podemos trnasformarlo

            int OrderId = await model.PlaceOrderAsync(shoppingCart);
            shoppingCart.ResetShoppingCart();
            IsSubmitting = false;
            return OrderId;
        }
    }
}
