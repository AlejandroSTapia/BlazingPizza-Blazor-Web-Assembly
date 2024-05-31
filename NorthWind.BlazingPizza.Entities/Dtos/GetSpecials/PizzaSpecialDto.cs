namespace NorthWind.BlazingPizza.Entities.Dtos.GetSpecials
{
	public class PizzaSpecialDto(int id, string name, 
		decimal basePrice, string description, string imageUrl)
	{
		public int Id => id;//solo expondra el parametro id hacia el exterior, no se mostrara en pantalla pero es identificador
		public string Name => name;
		public decimal BasePrice => basePrice;
		public string Description => description;
		public string ImageUrl => imageUrl;

		//se cambio a aqui desde el model como propiedad
		public string FormatterBasePrice =>
			basePrice.ToString("0.00");
	}
}
