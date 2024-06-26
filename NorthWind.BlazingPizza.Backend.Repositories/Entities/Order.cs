using NorthWind.BlazingPizza.Entities.Enums;

namespace NorthWind.BlazingPizza.Backend.Repositories.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public List<CustomPizza> Pizzas { get; set; }
        public OrderStatus Status { get; set; }
    }
}
