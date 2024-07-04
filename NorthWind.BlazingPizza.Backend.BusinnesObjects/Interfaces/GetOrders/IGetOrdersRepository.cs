using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders
{
    public interface IGetOrdersRepository
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersSortedByDescendingIdAsync();
    }
}
