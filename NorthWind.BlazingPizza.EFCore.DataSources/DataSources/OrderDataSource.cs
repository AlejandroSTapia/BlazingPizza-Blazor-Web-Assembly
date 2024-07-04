using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

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
            List<GetOrdersDto> getOrdersDtos = await queryBuilder(QueryableOrders).ToListAsync(); 
            return getOrdersDtos;
        }
    }
}
