using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;
using System.Net.Http.Json;

namespace NorthWind.BlazingPizza.Frontend.WebApiProxies.Checkout
{
    internal class CheckoutModel(HttpClient client) : ICheckoutModel
    {
        public async Task<int> PlaceOrderAsync(ShoppingCart order)
        {
            int OrderId = 0;
            var Response = await client.PostAsJsonAsync(Endpoints.PlaceOrder,
                (PlaceOrderOrderDto)order);
            if (Response.IsSuccessStatusCode)
            {
                OrderId = await Response.Content.ReadFromJsonAsync<int>();
            }
            return OrderId;
        }
    }
}
