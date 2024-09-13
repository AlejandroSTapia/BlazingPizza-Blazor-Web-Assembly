using DotNet.Validation.Entities.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ValidationService.FluentValidation
{
    internal class ValidationRules<T, TProperty>(
        IRuleBuilderInitial
        ) : IValidationRules<T, TProperty>
    {
    }
}
