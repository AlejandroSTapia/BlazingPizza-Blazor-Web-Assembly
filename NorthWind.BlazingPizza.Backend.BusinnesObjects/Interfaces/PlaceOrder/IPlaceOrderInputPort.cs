using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder
{
    public interface IPlaceOrderInputPort
    {
        Task<int> PlaceOrderAsync(PlaceOrderOrderDto order);
    }
}
