using Microsoft.AspNetCore.Builder;
using NorthWind.BlazingPizza.Backend.Controllers.GetOrder;
using NorthWind.BlazingPizza.Backend.Controllers.GetOrders;
using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;
using NorthWind.BlazingPizza.Backend.Controllers.GetToppings;
using NorthWind.BlazingPizza.Backend.Controllers.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.Controllers
{
    public static class EndpointsContainer
    {
        public static WebApplication UseBlazingPizzaControllers(
       this WebApplication app)
        {
            app.UseGetSpecialsController();
            app.UseGetToppingController();
            app.UsePlaceOrderController();
            app.UseGetOrdersController(); //se registra el endpoint creado en GetOrdersController
            app.UseGetOrderController();

            return app;
        }
    }
   
}
