using Microsoft.AspNetCore.Builder;
using NorthWind.BlazingPizza.Backend.Controllers;

namespace NorthWind.BlazingPizza.Backend.IoC;

public static class EndpointsContainer
{
	public static WebApplication UseBlazingpizzaEndpoints(
		this WebApplication app)
	{
		app.UseBlazingPizzaControllers();

		return app;
	}
}

