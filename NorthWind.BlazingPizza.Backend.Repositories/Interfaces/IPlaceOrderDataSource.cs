using NorthWind.BlazingPizza.Backend.Repositories.Entities;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IPlaceOrderDataSource
    {
        Task PlaceOrderAsync(Order order);
    }
}
