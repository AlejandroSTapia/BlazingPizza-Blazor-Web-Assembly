using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetToppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
	internal class ToppingDataSource : BlazingPizzaContext,
		IToppingDataSource
	{
		public ToppingDataSource(IOptions<DBOptions> options) : base(options)
		{
			ChangeTracker.QueryTrackingBehavior = 
				QueryTrackingBehavior.NoTracking;
		}

		public async Task<IEnumerable<ToppingDto>> GetToppingDtosFromQueryAsync(
			Func<IQueryable<Topping>, IQueryable<ToppingDto>> queryBuilder) =>
			await queryBuilder(Toppings).ToListAsync();
	}
}
