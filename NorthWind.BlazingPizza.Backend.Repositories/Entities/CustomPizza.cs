using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    [Table("CustomPizza", Schema = "blazingPizza")]
    public class CustomPizza
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PizzaSpecial PizzaSpecial { get; set; }
        public int PizzaSpecialId { get; set; }
        public int Size { get; set; }
        public List<CustomPizzaTopping> Toppings {  set; get; }
        public decimal TotalPrice { get; set; }
    }
}
