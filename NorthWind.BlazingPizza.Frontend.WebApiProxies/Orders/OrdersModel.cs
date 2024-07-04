using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Orders;
using System.Net.Http.Json;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Orders
{
    internal class OrdersModel(HttpClient client) : IOrdersModel
    {
        public async Task<IEnumerable<GetOrdersDto>> GetOrdersAsync() =>
           await client.GetFromJsonAsync<IEnumerable<GetOrdersDto>>(Endpoints.GetOrders);
    }
}
