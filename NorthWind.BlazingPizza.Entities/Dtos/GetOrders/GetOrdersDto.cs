using NorthWind.BlazingPizza.Entities.Enums;

namespace NorthWind.BlazingPizza.Entities.Dtos.GetOrders
{
    public class GetOrdersDto(
        int id, DateTime createdTime, int pizzasCount,
        decimal totalPrice, OrderStatus status)
    {
        public int Id => id;
        public DateTime CreatedTime => createdTime;
        public int PizzasCount => pizzasCount;
        public decimal TotalPrice => totalPrice;
        public OrderStatus Status => status;
        public string GetFormattedTotalPrice() =>
            totalPrice.ToString("0.00");
    }
}
