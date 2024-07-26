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

        public bool IsValidAddress { get; private set; }//para que la vista le pregunte al viewmodel y asi poder realizar el envio(si es valida o no la direccion)
        public bool ValidateAddress(AddressViewModel address)//para que la vista le diga al modelo que valide una direccion(logica en vista no, si en viewmodel)
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

            ValidateAddress(AddressViewModel);//por si la vista no valida(adicionalmente)

            if (IsValidAddress)
            {
                //ya se puede usar como aqui ya que se hizo en adresviewmodel
                //cast explicito que se implemento (explicit operator) en el viewmodel
                shoppingCart.DeliveryAddress = (AddressDto)AddressViewModel; 

                OrderId = await model.PlaceOrderAsync(shoppingCart);
                shoppingCart.ResetShoppingCart();
            }

            IsSubmitting = false;
            return OrderId;
        }
    }
}
