using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Orders
{
    public interface IOrdersModel
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
    }
}
