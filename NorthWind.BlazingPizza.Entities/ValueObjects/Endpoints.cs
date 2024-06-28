using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.ValueObjects
{
	//se definio el enpoint
	public class Endpoints
	{
		public const string GetSpecials = $"/{nameof(GetSpecials)}";

		//nuevo enpoint? nueva constante
		public const string GetToppings = $"/{nameof(GetToppings)}";
        public const string PlaceOrder = $"/{nameof(PlaceOrder)}";
		public const string GetOrders = $"/{nameof(GetOrders)}";
    }
}
