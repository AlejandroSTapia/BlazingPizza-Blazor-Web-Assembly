using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Enums
{
    public enum ValidationConstraint
    {
        AlwaysValidate, //Validar siempre
        ValidateIfThereAreNoPreviousErrors //solo valida si no hay errores previos
    }
}
