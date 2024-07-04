namespace NorthWind.BlazingPizza.Entities.Dtos.GetOrder
{
    public class GetOrderPizzaDto(string pizzaSpecialName,
        int size, IEnumerable<string> toppingNames, decimal totalPrice)
    {
        public string PizzaSpecialName => pizzaSpecialName;
        public int Size => size;
        public IEnumerable<string> ToppingNames => toppingNames;
        public decimal TotalPrice => totalPrice;

        public string GetFormattedTotalPrice() =>
            totalPrice.ToString("$ #,###.00");
    }
}
