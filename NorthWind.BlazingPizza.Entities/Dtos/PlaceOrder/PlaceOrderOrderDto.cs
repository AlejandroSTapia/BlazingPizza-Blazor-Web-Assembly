using NorthWind.BlazingPizza.Entities.Dtos.Common;

namespace NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder
{
    public class PlaceOrderOrderDto(IEnumerable<PlaceOrderPizzaDto> pizzas, AddressDto deliveryAddress)
    {
        public IEnumerable<PlaceOrderPizzaDto > Pizzas => pizzas;
        public AddressDto DeliveryAddress => deliveryAddress;
    }
}
