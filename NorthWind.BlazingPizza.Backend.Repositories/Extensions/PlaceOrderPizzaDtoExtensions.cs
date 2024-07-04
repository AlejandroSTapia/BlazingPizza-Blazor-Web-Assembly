using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.Repositories.Extensions
{
    internal static class PlaceOrderPizzaDtoExtensions
    {
        public static CustomPizza ToCustomPizza(
            this PlaceOrderPizzaDto pizza) =>
            new CustomPizza
            {
                PizzaSpecialId = pizza.PizzaSpecialId,
                Size = pizza.Size,
                Toppings = pizza.ToppingsId.Select(id =>
                new CustomPizzaTopping
                {
                    ToppingId = id,
                }).ToList(),
                TotalPrice = pizza.TotalPrice,
            };
    }
}
