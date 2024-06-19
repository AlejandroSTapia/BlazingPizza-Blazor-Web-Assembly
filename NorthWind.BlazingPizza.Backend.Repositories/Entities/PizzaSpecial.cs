using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    [Table("PizzaSpecials", Schema = "blazingPizza")]
    public class PizzaSpecial
	{
		public int Id {  get; set; }
		public string Name { get; set; }
		public decimal BasePrice { get; set; }
		public string Description { get; set; }
		public string ImageUrl { get; set; }
	}
}
