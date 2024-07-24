using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNet.Validation.Entities.Interfaces
{
    public interface IValidationRules<T, TProperty>
    {
        IValidationRules<T, TProperty> NotEmpty(string errorMessage);
        IValidationRules<T, TProperty> NotNull(string errorMessage);
        IValidationRules<T, TProperty> Must(Func<TProperty, bool> predicate,string errorMessage);
        //IValidationRules<T, TProperty> StopOnFirstFailure(string errorMessage);
        IValidationRules<T, TProperty> GreaterThan<TValue>(
            TValue valueToCompare, string errorMessage) where TValue: TProperty,
            IComparable<TValue>, IComparable;
        IValidationRules<T, TProperty> Equal(Expression<Func<T, TProperty>> expressions,
            string errorMessage);
        IValidationRules<T, TProperty> Length(int length, string errorMessage);
        IValidationRules<T, TProperty> MaximumLength(int length, string errorMessage);
        IValidationRules<T, TProperty> MinimumLength(int length, string errorMessage);
        IValidationRules<T, TProperty> EmailAddress(string errorMessage);
        IValidationRules<T, TProperty> Match(string regularExpression ,string errorMessage);
    }
}
