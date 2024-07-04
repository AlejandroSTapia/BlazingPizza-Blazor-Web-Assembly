using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Checkout
{
    public interface ICheckoutModel
    {
        Task<int> PlaceOrderAsync(ShoppingCart order);
    }
}
