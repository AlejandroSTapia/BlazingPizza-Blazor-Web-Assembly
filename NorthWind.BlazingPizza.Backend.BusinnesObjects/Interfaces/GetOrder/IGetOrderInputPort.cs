using NorthWind.BlazingPizza.Entities.Dtos.GetOrder;

namespace NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.GetOrder
{
    public interface IGetOrderInputPort
    {
        Task<GetOrderOrderDto> GetOrderAsync(int id);
    }
}
