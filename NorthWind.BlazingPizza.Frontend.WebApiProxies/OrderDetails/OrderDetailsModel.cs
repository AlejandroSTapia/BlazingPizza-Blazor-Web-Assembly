using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.OrderDetails
{
    internal class OrderDetailsModel(HttpClient client) : IOrderDetailsModel
    {
        public Task<GetOrderOrderDto> GetOrderAsync(int id) =>
            client.GetFromJsonAsync<GetOrderOrderDto>(
                $"{Endpoints.GetOrder}/{id}");
    }
}
