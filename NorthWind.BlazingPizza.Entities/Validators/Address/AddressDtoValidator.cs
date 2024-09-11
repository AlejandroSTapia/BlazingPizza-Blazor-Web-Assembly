using DotNet.Validation.Entities.Abstractions;
using DotNet.Validation.Entities.Interfaces;
using NorthWind.BlazingPizza.Entities.Dtos.Common;
using NorthWind.BlazingPizza.Entities.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.BlazingPizza.Entities.Validators.Address
{//esro remplazaria a las anotaciones d edatos

    internal class AddressDtoValidator : AbstractModelValidator<AddressDto>
    {
        //agregar reglas de validacion
        //se debe incoicar a addrules en el construct
        public AddressDtoValidator(
            //le pasamos lo que necesita la clase base y para que lo necesita? no lo se, solo se debe psar(con :base())
            IValidationService<AddressDto> validationService) : base(validationService)
        {
            //agregamos las reglas de validacion para nombre
            //aqui nos da las opciones porque se indico en AbstractModelValidator<AddressDto> de quien se esta validando
            AddRuleFor(a => a.Name)
                .NotNull(Messages.AddressNameRequiredErrorMessage) //que no sea nulo y en caso que sea nulo entonces se mandara el mensaje
                .MinimumLength(3, Messages.AddressNameMinimumLengthRequiredErrorMessage) //se pueden anidar las condiciones con .
                .MaximumLength(100, Messages.AddressNameMaximumLengthRequiredErrorMessage);

            //reglas para addressLine
            AddRuleFor(a => a.AddressLine1)
                .NotNull(Messages.AddressLine1RequiredErrorMessage) 
                .MinimumLength(5, Messages.AddressLine1MinimummLenghtRequiredErrorMessage) 
                .MaximumLength(100, Messages.AddressLine1MaximumLenghtRequiredErrorMessage);

            AddRuleFor(a => a.AddressLine2)
                .MaximumLength(100, Messages.AddressLine2MaximumLenghtRequiredErrorMessage);

            AddRuleFor(a => a.City)
                .NotNull(Messages.AddressCityRequiredErrorMessage)
                .MinimumLength(3, Messages.AddressCityMinimumLengthRequiredErrorMessage)
                .MaximumLength(100, Messages.AddressCityMaximumLengthRequiredErrorMessage);

            AddRuleFor(a => a.Region)
                .NotNull(Messages.AddressRegionRequiredErrorMessage)
                .MinimumLength(3, Messages.AddressRegionMinimumLengthRequiredErrorMessage)
                .MaximumLength(50, Messages.AddressRegionMaximumLengthRequiredErrorMessage);

            AddRuleFor(a => a.PostalCode)
                .NotNull(Messages.AddressPostalCodeRequiredErrorMessage)
                .Matches("[0-9]{5}", Messages.AddressPostalCodeInvalidErrorMessage);
        }
    }
}
