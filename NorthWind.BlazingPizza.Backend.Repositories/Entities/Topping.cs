using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
