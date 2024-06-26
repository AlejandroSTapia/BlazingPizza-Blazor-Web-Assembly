using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder
{
    public class PlaceOrderOrderDto(IEnumerable<PlaceOrderPizzaDto> pizzas)
    {
        public IEnumerable<PlaceOrderPizzaDto > Pizzas => pizzas;
    }
}
