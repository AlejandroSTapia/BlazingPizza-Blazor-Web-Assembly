using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IOrderDataSource
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersFromQueryAsync(
            Func<IQueryable<Order>, IQueryable<GetOrdersDto>> queryBuilder);
    }
}
