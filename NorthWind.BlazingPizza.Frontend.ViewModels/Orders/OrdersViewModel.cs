using NorthWind.BlazingPizza.Entities.Dtos.GetOrders;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.Orders;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.Orders
{
    public class OrdersViewModel(IOrdersModel model)
    {
        public IEnumerable<GetOrdersDto> Orders { get;  private set; }
        public async Task GetOrdersAsync()
        { 
            Orders = await model.GetOrdersAsync();       
        } 
    }
}
