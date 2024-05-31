
using NorthWind.BlazingPizza.Entities.Dtos.GetSpecials;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.GetSpecials
{
	//Aqui va
		//Que es lo que queremos   -  Por ende se empeiza por el que, no como(que vfa en capas exteriore)
	public interface IGetSpecialsModel
	{
		//se queire que se devuelvan los datos de la pizza

		//se enumera para que pueda recorrer la coleccion de piza e ir generarndo la interfaz de usuario
		Task<IEnumerable<PizzaSpecialDto>> GetSpecialsAsync();
	}
}


//en tiempo de diseño no se necesita de GetspecialModel(3), se necesita  de esta interfaz( abstraccion)
// Pero en tiempo de ejecucion si se necesita, si se conoce del modelo(pues tiene la logica)(interactor o implementacion)

//en tiempo de ejecucion se necesita del contenedor de inyeccion de dependencias
//En el patron de inyeccoion de dependencias
	//registramos en un contedor las implementaciones
	// y las mapeamos con las abstraccuibes
//Entonces en el contenedor de inyeccion de dependencias se va a tener:
	//la abstraccion y su implementador


//Entonces en tiempo de ejecucion se va a pedir al contenedor de inyecion el IGetSpecialModel
//y el contendor de inyecion(asumiendo que este ya lo conoce) me va a devolver una instacnia de getEspcialModel

//Se debe registrar la implemnentacion ante el contenedor de dependencias, para ello se crea un:
	//Metodo de extension :DependencyContainer			En proxies

