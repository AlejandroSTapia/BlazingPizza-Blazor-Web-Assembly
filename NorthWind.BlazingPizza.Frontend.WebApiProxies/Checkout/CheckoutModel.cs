﻿using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Checkout;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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