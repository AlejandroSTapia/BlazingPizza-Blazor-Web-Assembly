using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    [Table("Toppings", Schema = "blazingPizza")]
    public class Topping
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
	}
}
