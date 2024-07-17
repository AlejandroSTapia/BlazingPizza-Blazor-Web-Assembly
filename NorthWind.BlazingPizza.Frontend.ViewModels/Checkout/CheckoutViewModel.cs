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

        public bool IsValidAddress { get; private set; }
        public bool ValidateAddress(AddressViewModel address)
        {
            IsValidAddress =
                !string.IsNullOrWhiteSpace(address.Name) &&
                !string.IsNullOrWhiteSpace(address.AddressLine1) &&
                !string.IsNullOrWhiteSpace(address.PostalCode);

            return IsValidAddress;
        }
        public async Task<int> PlaceOrderAsync()
        {
            IsSubmitting = true;

            int OrderId = 0;

            if (IsValidAddress)
            {
                shoppingCart.DeliveryAddress = (AddressDto)AddressViewModel; //cast explicito que se implemento (explicit operator) en el viewmodel, con eso ya podemos trnasformarlo

                OrderId = await model.PlaceOrderAsync(shoppingCart);
                shoppingCart.ResetShoppingCart();
            }
            IsSubmitting = false;
            return OrderId;
        }
    }
}
