using DotNet.Validation.Entities.Interfaces;
using NorthWind.BlazingPizza.Backend.BusinnesObjects.Interfaces.PlaceOrder;
using NorthWind.BlazingPizza.Entities.Dtos.Common;
using NorthWind.BlazingPizza.Entities.Dtos.PlaceOrder;

namespace NorthWind.BlazingPizza.Backend.UseCases.PlaceOrder
{
    //El cereblo de los casos de uso esta en los useCases
    internal class PlaceOrderInteractor(
        IPlaceOrderRepository repository,
        IModelValidatorHub<AddressDto> addressvalidator) : IPlaceOrderInputPort
    {
        //Cuando se debe validar la direccion? Cuando se hace la orden en Placeorder

        //
        public async Task<int> PlaceOrderAsync(PlaceOrderOrderDto order)
        {
            int OrderId = 0;
            if(await addressvalidator.Validate(order.DeliveryAddress))
            {
                OrderId = await repository.PlaceOrderAsync(order);
            }
            else
            {
                string Errors = string.Join("",
                    addressvalidator.Errors
                    .Select(equals => $"{equals.PropertyName}: {equals.Message}"));
                throw new Exception(Errors);
            }
            return OrderId;
        }
        
    }
}
