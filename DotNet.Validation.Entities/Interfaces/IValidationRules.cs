using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    //aplicaran a un modelo, pero de un modelo aplicaran directamente a una propiedad del modelo
    public interface IValidationRules<T, TProperty>
    {
        //regla para decir que una propiedad no venga vacia y que develva el mismo IValidationRules de TProperty
        IValidationRules<T, TProperty> NotEmpty(string errorMessage); //para poder enlazar validaciones
        IValidationRules<T, TProperty> NotNull(string errorMessage);
        IValidationRules<T, TProperty> Must(Func<TProperty, bool> predicate,string errorMessage);
        IValidationRules<T, TProperty> StopOnFirstFailure();
        IValidationRules<T, TProperty> GreaterThan<TValue>(
            TValue valueToCompare, string errorMessage) where TValue: TProperty,
            IComparable<TValue>, IComparable; //solo comparara si valor a comparar es del mismo tipo que la propiedad
        IValidationRules<T, TProperty> Equal(Expression<Func<T, TProperty>> expressions,
            string errorMessage);
        IValidationRules<T, TProperty> Length(int length, string errorMessage);
        IValidationRules<T, TProperty> MaximumLength(int length, string errorMessage);
        IValidationRules<T, TProperty> MinimumLength(int length, string errorMessage);
        IValidationRules<T, TProperty> EmailAddress(string errorMessage);
        IValidationRules<T, TProperty> Matches(string regularExpression ,string errorMessage);//para expresiones regulares

        //El tipo del modelo a validar esta definido en el parametro T
        //y el tipo de la propiedad qeu deseamos validar esta en TProperty
    }
}
