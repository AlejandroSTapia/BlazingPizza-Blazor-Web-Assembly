using DotNet.Validation.Entities;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazingPizza.Entities.Dtos.Common;
using NorthWind.BlazingPizza.Entities.Validators.Address;

namespace NorthWind.BlazingPizza.Entities
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddModelValidator<AddressDto, AddressDtoValidator>();
            return services;
        }
    }
}
