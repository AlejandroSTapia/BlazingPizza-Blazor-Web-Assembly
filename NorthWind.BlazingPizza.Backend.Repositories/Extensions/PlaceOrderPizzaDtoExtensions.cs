using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
