using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Frontend.BusinessObjects.Interfaces.OrderDetails
{
    public interface IOrderDetailsModel
    {
        Task<GetOrderOrderDto> GetOrderAsync(int id);
    }
}
