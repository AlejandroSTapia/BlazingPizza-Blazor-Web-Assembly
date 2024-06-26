using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.Repositories.Interfaces
{
    public interface IPlaceOrderDataSource
    {
        Task PlaceOrderAsync(Order order);
    }
}
