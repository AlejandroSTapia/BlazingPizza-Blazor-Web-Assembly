namespace NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder
{
    public class PlaceOrderOrderDto(IEnumerable<PlaceOrderPizzaDto> pizzas)
    {
        public IEnumerable<PlaceOrderPizzaDto > Pizzas => pizzas;
    }
}
