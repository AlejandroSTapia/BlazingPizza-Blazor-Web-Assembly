using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrders;
using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;

namespace NorthWind.BlazingPizza.Backend.UseCases.GetOrders
{
    internal class GetOrdersInteractor(IGetOrdersRepository repository) : IGetOrdersInputPort
    {
        public async Task<IEnumerable<GetOrdersDto>> GetOrdersAsync() =>
           await repository.GetOrdersSortedByDescendingIdAsync();
    
    }
}
