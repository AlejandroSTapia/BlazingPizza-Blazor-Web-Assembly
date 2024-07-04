using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    [Table("CustomPizzaTopping", Schema = "blazingPizza")]
    public class CustomPizzaTopping
    {
        public int CustomPizzaId { get; set; }
        public Topping Topping { get; set; }
        public int ToppingId { get; set; }
    }
}
