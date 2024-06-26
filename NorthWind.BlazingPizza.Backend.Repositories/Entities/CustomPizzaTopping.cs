using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    public class CustomPizzaTopping
    {
        public int CustomPizzaId { get; set; }
        public Topping Topping { get; set; }
        public int ToppingId { get; set; }
    }
}
