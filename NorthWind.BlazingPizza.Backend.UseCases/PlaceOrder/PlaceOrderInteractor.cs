using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder
{
    internal class PlaceOrderInteractor(
        IPlaceOrderRepository repository) : IPlaceOrderInputPort
    {
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
        =>
            await repository.PlaceOrderAsync(order);
        
    }
}
