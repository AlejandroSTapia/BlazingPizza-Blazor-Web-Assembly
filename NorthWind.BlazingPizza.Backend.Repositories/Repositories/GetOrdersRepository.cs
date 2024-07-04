using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetOrdersRepository(IOrderDataSource dataSource) : IGetOrdersRepository
    {
        public async Task<IEnumerable<GetOrdersDto>> GetOrdersSortedByDescendingIdAsync()=>
             await dataSource.GetOrdersFromQueryAsync(
                orders => orders.OrderByDescending(o => o.Id)
                .Select(o => new GetOrdersDto(o.Id,
                    o.CreatedTime,
                    o.Pizzas.Count,
                    o.Pizzas.Sum(p => p.TotalPrice),
                    o.Status)));        
    }
}
