using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Backend.Repositories.Extensions;
using NorthWind.BlazingPizza.Backend.Repositories.Interfaces;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Enums;

namespace NorthWind.BlazingPizza.Backend.Repositories.Repositories
{
    internal class PlaceOrderRepository(
        IPlaceOrderDataSource dataSource) : IPlaceOrderRepository
    {
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
        {
            var Order = new Order();
            Order.CreatedTime =DateTime.Now;
            Order.Status = OrderStatus.Preparing;

            Order.Pizzas = order.Pizzas
                .Select(p=> p.ToCustomPizza()).ToList();

            Order.DeliveryAddress = order.DeliveryAddress.ToAddress(); //se usa el metodo de extension creado(convertirdo a address)

            await dataSource.PlaceOrderAsync(Order);
            return Order.Id;
        }
    }
}
