using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetOrders
{
    internal static class GetOrdersController
    {
        public static WebApplication UseGetOrderController(
            this WebApplication app)
        {
            app.MapGet(Endpoints.GetOrders,
                async (IGetOrdersInputPort inputPort) =>
                TypedResults.Ok(await inputPort.GetOrdersAsync()));//exponiendo el endpoint para que se consuma
            return app;
        }
    }
}
