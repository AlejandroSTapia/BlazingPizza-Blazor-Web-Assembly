using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Extensions;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using NorthWind.BlazingPizza.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
    internal class GetOrderDataSourceSQL(IOptions<DBOptions> options) :
        DbContext, IGetOrderDataSource
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(options.Value.ConnectionString);
        }

        // entity para trabajar con entidades que no estan mapeadas en la bd, solo para realizar consulta
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QueryResultEntity>().HasNoKey()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ;
        }

        public async Task<GetOrderOrderDto> GetOrderByIdAsync(int orderId)
        {
            string SQL = $@"
SELECT o.Id OrderId, o.CreatedTime, o.Status, cp.Id CustomPizzaId,

ps.Name PizzaSpecialName, cp.Size, cp.TotalPrice, t.Name ToppingName
FROM ORDERS o
INNER JOIN CustomPizzas cp ON o.Id = cp.OrderId
INNER JOIN PizzaSpecials ps ON cp.PizzaSpecialId = ps.id
LEFT JOIN CustomPizzaTopping cpt ON cp.Id = cpt.CustomPizzaId
LEFT JOIN Toppings t ON cpt.ToppingId = t.Id
WHERE o.Id = {orderId}
 
";
            //FromSqlRaw devuelve un iquerable
            IQueryable<QueryResultEntity> Query = Set<QueryResultEntity>().FromSqlRaw(SQL);

            //Debug.WriteLine(Query.ToQueryString());

            var QueryResult = await Query.ToListAsync();

            GetOrderOrderDto Result = ToGetOrderOrderDto(QueryResult);

            //Result = QueryResult
            //    .GroupBy(o => o.OrderId)
            //    .Select(g => new GetOrderOrderDto(
            //        g.Key,
            //        g.First().CreatedTime,
            //    g.GroupBy(p => p.CustomPizzaId)
            //    .Select(p => new GetOrderPizzaDto(
            //        p.First().PizzaSpecialName,
            //        p.First().Size,
            //        p.Select(t => t.ToppingName)
            //        .Where(t => t != null),
            //        p.Sum(p => p.TotalPrice))),
            //        g.First().Status))
            //    .FirstOrDefault();

            return Result ?? new GetOrderOrderDto(0,
                DateTime.MinValue, [], OrderStatus.Preparing);
        }

        GetOrderOrderDto ToGetOrderOrderDto(IEnumerable<QueryResultEntity> set)
        {
            return set
                .GroupBy(o => o.OrderId)
                .Select(g => new GetOrderOrderDto(
                    g.Key,
                    g.First().CreatedTime,
                g.GroupBy(p => p.CustomPizzaId)
                .Select(p => new GetOrderPizzaDto(
                    p.First().PizzaSpecialName,
                    p.First().Size,
                    p.Select(t => t.ToppingName)
                    .Where(t => t != null),
                    p.Sum(p => p.TotalPrice))),
                    g.First().Status))
                .FirstOrDefault();
        }

        class QueryResultEntity
        {
            public int OrderId { get; set; }
            public DateTime CreatedTime { get; set; }
            public OrderStatus Status { get; set; }
            public int CustomPizzaId { get; set; }
            public string PizzaSpecialName { get; set; }
            public int Size { get; set; }
            public decimal TotalPrice { get; set; }
            public string ToppingName { get; set; }

        }
    }
}
