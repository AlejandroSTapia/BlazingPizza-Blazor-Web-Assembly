using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.ViewModels.OrderDetails
{
    public class OrderDetailsViewModel(IOrderDetailsModel model)
    {
        public GetOrderOrderDto Order { get; private set; }
        public bool InvalidOrder { get; private set; }
        public async Task GetOrderAsync(int id)
        {
            Order = await model.GetOrderAsync(id);
         
                InvalidOrder = Order.Id == 0;
         
        }
    }
}
