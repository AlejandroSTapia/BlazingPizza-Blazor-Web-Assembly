using DotNet.Validation.Entities.Enums;
using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    //Validador
    //sera capaz de trabajar con cualquier tipo d emodelo
    public interface IModelValidator<T>//interfaz generica
    {
        //debee exponer un metodo que permita validar
        Task<bool> Validate(T model);//recibira un modelo a validar regresando un valor bool
        //pero no sera suficiente con eso, para eso requerira un:
        IEnumerable<ValidationError> Errors { get; } //para asaber cuales fueron los errores
        //exponer que permita indicar cuando puede ser validado o no
        ValidationConstraint Constraint { get; }
    }
}
