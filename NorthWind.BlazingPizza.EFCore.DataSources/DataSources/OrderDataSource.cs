using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class OrderDataSource : BlazingPizzaContext,
        IOrderDataSource
    {
        public OrderDataSource(IOptions<DBOptions> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public async Task<IEnumerable<GetOrdersDto>> GetOrdersFromQueryAsync(
            Func<IQueryable<Order>, IQueryable<GetOrdersDto>> queryBuilder)
        {
            //necesitamos que incluya las pizzas(count, prop que falta en entidad) con include
            var QueryableOrders = Orders
                .Include(o=> o.Pizzas);
            return await queryBuilder(Orders).ToListAsync(); 
        }
    }
}
