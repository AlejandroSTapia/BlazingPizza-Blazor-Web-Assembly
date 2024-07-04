using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IOrderDataSource
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersFromQueryAsync(
            Func<IQueryable<Order>, IQueryable<GetOrdersDto>> queryBuilder);
    }
}
