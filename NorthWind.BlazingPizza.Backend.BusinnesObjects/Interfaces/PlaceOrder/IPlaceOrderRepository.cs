using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderRepository
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
