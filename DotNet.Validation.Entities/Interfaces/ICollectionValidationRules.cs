using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    public interface ICollectionValidationRules<T, TProperty>
    {
        //para establecer reglas para colecciones
        //por ejemplo, la coleccion de topings solo usare ciertas reglas, otra coleccion usara otra coleccion de rglas
        ICollectionValidationRules<T, TProperty> SetValidator(
            IModelValidator<TProperty> validator);
    }
}
