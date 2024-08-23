using DotNet.Validation.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    //Concentrador de validadores
    //tendra todos los validadores para un modelo
    public interface IModelValidatorHub<T>
    {
        Task<bool> Validate(T model);//invocara el validate de cada modelValidate
        IEnumerable<ValidationError> Errors { get; } //para exponer los validate recibidos y exponer los errores de validacion
    }
}
