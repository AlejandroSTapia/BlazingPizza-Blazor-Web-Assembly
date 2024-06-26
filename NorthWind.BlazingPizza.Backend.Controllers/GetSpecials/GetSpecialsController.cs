using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Controllers.GetSpecials
{
	//sirve como puerta de entrada y definir endpoint
	internal static class GetSpecialsController
	{
		public static WebApplication UseGetSpecialsController( this WebApplication app) //se extiende WebApplication
		{
			//exponer el endpoint
			//app.MapGet("/getspecials")
			app.MapGet(Endpoints.GetSpecials, //se usa el enpoint
				async (IGetSpecialsInputPort inputPort,
				IGetSpecialsOutputPort presenter) =>
				{
					//que hacer?
					await inputPort.GetSpecialsAsync();
					return TypedResults.Ok(presenter.PizzaSpecials);//se devolvera como una respuesta ok, como http200
				}); 
			return app;
		}
	}
}


//controlador de mvc tiene muchas mas opciones por eso se usa esta