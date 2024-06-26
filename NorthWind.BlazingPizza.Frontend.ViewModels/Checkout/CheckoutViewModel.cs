using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Checkout
{
    public class CheckoutViewModel(
        ICheckoutModel model,
        ShoppingCart shoppingCart)
    {
        public bool IsSubmitting { get; set; }
        public async Task<int> PlaceOrderAsync()
        {
            IsSubmitting = true;
            int OrderId = await model.PlaceOrderAsync(shoppingCart);
            shoppingCart.ResetShoppingCart();
            IsSubmitting = false;
            return OrderId;
        }
    }
}
