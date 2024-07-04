using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrder;
using NorthWind.BlazingPizza.Entities.ValueObjects;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetOrder
{
    internal static class GetOrderController
    {
        public static WebApplication UseGetOrderController(
            this WebApplication app)
        {
            app.MapGet($"{Endpoints.GetOrder}/{{id}}",
                async (IGetOrderInputPort inputPort, int id) =>
                TypedResults.Ok(
                    await inputPort.GetOrderAsync(id)));

            return app;
        }
    }
}
