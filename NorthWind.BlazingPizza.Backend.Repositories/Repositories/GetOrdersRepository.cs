using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class GetOrdersRepository(IOrderDataSource dataSource) : IGetOrdersRepository
    {
        public Task<IEnumerable<GetOrdersDto>> GetOrdersSortedByDescendingIdAsync() =>
            dataSource.GetOrdersFromQueryAsync(
                orders => orders.OrderByDescending(o=> o.Id)
                .Select(o => new GetOrdersDto(o.Id,
                    o.CreatedTime,
                    o.Pizzas.Count,
                    o.Pizzas.Sum(p => p.TotalPrice),
                    o.Status)));
    }
}
