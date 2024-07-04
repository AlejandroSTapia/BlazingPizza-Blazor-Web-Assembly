using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IPizzaSpecialDataSource //este tiene los datos, yo no
	{
		//para permitir hacer consultas, en lugar de traer todo
		Task<IEnumerable<PizzaSpecialDto>> GetPizzaSpecialDtosFromQueryAsync(
			Func<IQueryable<PizzaSpecial>,
				IQueryable<PizzaSpecialDto>> queryBuilder);//se le pasara un delegado(apuntador a un metodo) para proporcionarte la consulta en lugar de un query
	//Esto qu devuelve? datos no porque ya los tiene
	
		//Proporciona un queryable PizzaEspecial y 
		//recibe Iqueryable PizzaSpecialDto   - Se manda toda la consulta a la fuente de datos
	}
}

//Los dto son solo para transportar datos
//los entities son para modificar datos


//La fuente de datos solo va a saber el origen, no que
