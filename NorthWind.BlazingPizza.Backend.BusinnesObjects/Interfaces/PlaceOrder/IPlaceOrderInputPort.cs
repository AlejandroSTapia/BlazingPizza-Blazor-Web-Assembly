using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderInputPort
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
