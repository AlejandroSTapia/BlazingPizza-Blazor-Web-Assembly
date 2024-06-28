using Microsoft.AspNetCore.Builder;
using NorthWind.BlazingPizza.Backend.Controllers.GetOrders;
using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;
using NorthWind.BlazingPizza.Backend.Controllers.GetToppings;
using NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Controllers
{
    public static class EndpointsContainer
    {
        public static WebApplication UseBlazingPizzaControllers(
       this WebApplication app)
        {
            app.UseGetSpecialsController();
            app.UseGetToppingController();
            app.UsePlaceorderController();
            app.UseGetOrderController(); //se registra el endpoint creado en GetOrdersController
            return app;
        }
    }
   
}
