using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetToppings
{
	public static class GetToppingsController 
	{
		public static WebApplication UseGetToppingController(
			this WebApplication app)
		{
			app.MapGet(Endpoints.GetToppings,
				async(IGetToppingsInputPort inputPort)=>
				TypedResults.Ok(await inputPort.GetToppingsAsync()));
			return app;
		}
	}
}
