using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;

namespace NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder
{
    internal static class PlaceOrderController
    {
        public static WebApplication UsePlaceOrderController(
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
