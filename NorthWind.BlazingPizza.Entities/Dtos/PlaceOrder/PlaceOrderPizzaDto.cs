namespace NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder
{
    public class PlaceOrderPizzaDto(int pizzaSpecialId, int size, 
        IEnumerable<int> toppingsId, decimal totalPrice)
    {
        public int PizzaSpecialId => pizzaSpecialId;
        public int Size => size;
        public IEnumerable<int> ToppingsId => toppingsId;
        public decimal TotalPrice => totalPrice;
    }
}
