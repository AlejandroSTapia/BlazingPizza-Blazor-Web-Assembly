using Microsoft.AspNetCore.Builder;
using NorthWind.BlazingPizza.Backend.Controllers.GetSpecials;
using NorthWind.BlazingPizza.Backend.Controllers.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.IoC;

	public static class EndpointsContainer
{
	public static WebApplication UseBlazingpizzaEndpoints(
		this WebApplication app)
	{
		app.UseGetSpecialsController();
		app.UseGetToppingController();
		return app;
	}
}

