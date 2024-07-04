using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IGetOrderDataSource
    {
        Task<GetOrderOrderDto> GetOrderByIdAsync(int orderId);
    }
}
