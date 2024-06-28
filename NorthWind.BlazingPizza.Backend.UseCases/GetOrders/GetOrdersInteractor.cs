using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetOrders
{
    internal class GetOrdersInteractor(IGetOrdersRepository repository) : IGetOrdersInputPort
    {
        public Task<IEnumerable<GetOrdersDto>> GetOrdersAsync() =>
            repository.GetOrdersSortedByDescendingIdAsync();
    
    }
}
