using NorthWind.BlazingPizza.Backend.Repositories.Entities;
using NorthWind.BlazingPizza.Entities.Dtos.Common;

namespace NorthWind.BlazingPizza.Backend.Repositories.Extensions
{
    public static class AddressDtoExtensions
    {
        public static Address ToAddress(this AddressDto address) =>
            new Address
            {
                Name = address.Name,
                AddressLine1 = address.AddressLine1,
                AddressLine2 = address.AddressLine2,
                City = address.City,
                Region = address.Region,
                PostalCode = address.PostalCode,
            };
    }
}
