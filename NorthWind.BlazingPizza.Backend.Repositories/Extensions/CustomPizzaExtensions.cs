using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Backend.Repositories.Extensions
{
    public static class CustomPizzaExtensions
    {
        public static GetOrderPizzaDto ToGetOrderPizzaDto(
            this CustomPizza pizza) =>
            new GetOrderPizzaDto(pizza.PizzaSpecial.Name,
                pizza.Size, pizza.Toppings.Select(t => t.Topping.Name),
                pizza.TotalPrice);
    }
}
