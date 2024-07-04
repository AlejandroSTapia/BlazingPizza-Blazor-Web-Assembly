﻿using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetSpecials;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    //que se arma en dataSource: Armar la consulta
    internal class GetSpecialsRepository(
		IPizzaSpecialDataSource dataSource) : IGetSpecialsRepository
	{
		public Task<IEnumerable<PizzaSpecialDto>> GetSpecialsSortedByDescendingPriceAsync() =>
			dataSource.GetPizzaSpecialDtosFromQueryAsync(
				//Aqui se devuelve la consulta
				PizzaSpecial =>
				PizzaSpecial.OrderByDescending(s => s.BasePrice)
				.Select(s => new PizzaSpecialDto(
					s.Id, s.Name, s.BasePrice, s.Description, s.ImageUrl
					)
				));
		
	}
}
