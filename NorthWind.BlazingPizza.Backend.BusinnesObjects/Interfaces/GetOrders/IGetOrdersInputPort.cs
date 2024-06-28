using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders
{
    public interface IGetOrdersInputPort
    {
        Task<IEnumerable<GetOrdersDto>> GetOrdersAsync();
    }
}
