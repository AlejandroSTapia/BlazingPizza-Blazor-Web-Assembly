using NorthWind.BlazingPizza.Entities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    [Table("Orders", Schema = "blazingPizza")]
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<CustomPizza> Pizzas { get; set; }
        public OrderStatus Status { get; set; }
        //propiedad de navegacion
        public Address DeliveryAddress { get; set; }//esto es suficinete para EF, para hacer la relacionn
        //con Ordrr y address, no necesitamos esecificar algo adicional
    }
}
