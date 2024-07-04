using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetToppings;
using NorthWind.BlazingPizza.Entities.ValueObjects;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetToppings
{
    internal static class GetToppingsController 
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
