using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder
{
    internal static class PlaceOrderController
    {
        public static WebApplication UsePlaceorderController(
            this WebApplication app)
        {
            app.MapPost(Endpoints.PlaceOrder,
                async (IPlaceOrderInputPort inputPort,
                PlaceOrderOrderDto order)=>
                TypedResults.Ok(await inputPort.PlaceOrderAsync(order)));
            return app;
        }
    }
}
