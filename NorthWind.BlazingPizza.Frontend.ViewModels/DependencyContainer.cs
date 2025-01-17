﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Frontend.ViewModels.GetSpecials;

namespace NorthWind.BlazingPizza.Frontend.ViewModels
{
	public static class DependencyContainer
	{
		//La funcionalidad de este metodo es agregar los viewModels
		public static IServiceCollection AddViewModels(
			this IServiceCollection services)
		{
			services.AddScoped<GetSpecialsViewModel>();
			return services;
		}
	}
}
