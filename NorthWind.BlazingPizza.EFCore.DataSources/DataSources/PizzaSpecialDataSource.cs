using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.EFCore.DataSources.DataSources
{
	//se implementa el servicio
	internal class PizzaSpecialDataSource: BlazingPizzaContext, IPizzaSpecialDataSource
	{
		public PizzaSpecialDataSource(IOptions<DBOptions> options): base(options)
		{
			ChangeTracker.QueryTrackingBehavior =
				Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
		}		

		public async Task<IEnumerable<PizzaSpecialDto>> GetPizzaSpecialDtosFromQueryAsync(
			Func<IQueryable<PizzaSpecial>, IQueryable<PizzaSpecialDto>> queryBuilder)
		{
			//se recivira un delegado querybuilder
			IQueryable<PizzaSpecialDto> Query = queryBuilder(PizzaSpecials);
			return await Query.ToListAsync();
		}
	}
}
